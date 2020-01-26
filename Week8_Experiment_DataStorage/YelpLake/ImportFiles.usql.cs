using Microsoft.Analytics.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NcuPhd
{
    [SqlUserDefinedExtractor(AtomicFileProcessing = true)]
    public class JsonExtractor : IExtractor
    {
        /// <summary/>
        private string rowpath;

        /// <summary/>
        public JsonExtractor(string rowpath = null)
        {
            this.rowpath = rowpath;
        }

        /// <summary/>
        public override IEnumerable<IRow> Extract(IUnstructuredReader input, IUpdatableRow output)
        {
            // Json.Net
            using (var reader = new JsonTextReader(new StreamReader(input.BaseStream)))
            {
                // Parse Json one token at a time
                while (reader.Read())
                {
                    if (reader.TokenType == JsonToken.StartObject)
                    {
                        var token = JToken.Load(reader);

                        // Rows
                        //  All objects are represented as rows
                        foreach (JObject o in SelectChildren(token, this.rowpath))
                        {
                            // All fields are represented as columns
                            this.JObjectToRow(o, output);

                            yield return output.AsReadOnly();
                        }
                    }
                }
            }
        }

        /// <summary/>
        private static IEnumerable<JObject> SelectChildren(JToken root, string path)
        {
            // JObject children (only)
            //   As JObject(fields) have a clear mapping to Row(columns) as opposed to JArray (positional) or JValue(scalar)
            //  Note: 
            //   We ignore other types (as opposed to fail fast) since JSON supports heterogeneous (schema)
            //   We support the values that can be mapped, without failing all of them if one of happens to not be an Object.

            // Path specified
            if (!string.IsNullOrEmpty(path))
            {
                return root.SelectTokens(path).OfType<JObject>();
            }

            // Single JObject
            var o = root as JObject;
            if (o != null)
            {
                return new[] { o };
            }

            // Multiple JObjects
            return root.Children().OfType<JObject>();
        }

        /// <summary/>
        protected virtual void JObjectToRow(JObject o, IUpdatableRow row)
        {
            foreach (var c in row.Schema)
            {
                JToken token = null;
                object value = c.DefaultValue;

                // All fields are represented as columns
                //  Note: Each JSON row/payload can contain more or less columns than those specified in the row schema
                //  We simply update the row for any column that matches (and in any order).
                if (o.TryGetValue(c.Name, out token) && token != null)
                {
                    // Note: We simply delegate to Json.Net for all data conversions
                    //  For data conversions beyond what Json.Net supports, do an explicit projection:
                    //      ie: SELECT DateTime.Parse(datetime) AS datetime, ...
                    //  Note: Json.Net incorrectly returns null even for some non-nullable types (sbyte)
                    //      We have to correct this by using the default(T) so it can fit into a row value
                    value = ConvertToken(token, c.Type) ?? c.DefaultValue;
                }

                // Update
                row.Set<object>(c.Name, value);
            }
        }

        internal static object ConvertToken(JToken token, Type type)
        {
            try
            {
                if (type == typeof(string))
                {
                    return GetTokenString(token);
                }

                // We simply delegate to Json.Net for data conversions
                return token.ToObject(type);
            }
            catch (Exception e)
            {
                // Make this easier to debug (with field and type context)
                //  Note: We don't expose the actual value to be converted in the error message (since it might be sensitive, information disclosure)
                throw new JsonSerializationException(
                    string.Format(typeof(JsonToken).Namespace + " failed to deserialize '{0}' from '{1}' to '{2}'", token.Path, token.Type.ToString(), type.FullName),
                    e);
            }
        }

        internal static string GetTokenString(JToken token)
        {
            switch (token.Type)
            {
                case JTokenType.Null:
                case JTokenType.Undefined:
                    return null;

                case JTokenType.String:
                    return (string)token;

                case JTokenType.Integer:
                case JTokenType.Float:
                case JTokenType.Boolean:
                    // For scalars we simply delegate to Json.Net (JsonConvert) for string conversions
                    //  This ensures the string conversion matches the JsonTextWriter
                    return JsonConvert.ToString(((JValue)token).Value);

                case JTokenType.Date:
                case JTokenType.TimeSpan:
                case JTokenType.Guid:
                    // For scalars we simply delegate to Json.Net (JsonConvert) for string conversions
                    //  Note: We want to leverage JsonConvert to ensure the string conversion matches the JsonTextWriter
                    //        However that places surrounding quotes for these data types.
                    var v = JsonConvert.ToString(((JValue)token).Value);
                    return v != null && v.Length > 2 && v[0] == '"' && v[v.Length - 1] == '"' ? v.Substring(1, v.Length - 2) : v;

                default:
                    // For containers we delegate to Json.Net (JToken.ToString/WriteTo) which is capable of serializing all data types, including nested containers
                    return token.ToString();
            }
        }
    }
}
