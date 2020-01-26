using Newtonsoft.Json;
using Parquet;
using System;
using System.Collections.Generic;
using System.IO;
using YelpToParquet.Models;

namespace YelpToParquet
{
    class Program
    {
        static void Main(string[] args)
        {
            var dir = @"s:\yelp\";
            WriteFile<Tip>(new FileInfo(Path.Combine(dir, "tip.json")));
            WriteFile<Business>(new FileInfo(Path.Combine(dir, "business.json")));
            WriteFile<Checkin>(new FileInfo(Path.Combine(dir, "checkin.json")));
            WriteFile<Photo>(new FileInfo(Path.Combine(dir, "photo.json")));
            WriteFile<Review>(new FileInfo(Path.Combine(dir, "review.json")));
            WriteFile<User>(new FileInfo(Path.Combine(dir, "user.json")));
        }

        static void WriteFile<T>(FileInfo file)
            where T: new()
        {
            string json;
            var outPath = Path.ChangeExtension(file.FullName, ".pqt");
            using var reader = new StreamReader(file.OpenRead());
            var list = new List<T>();
            while ((json = reader.ReadLine()) != null)
            {
                var instance = JsonConvert.DeserializeObject<T>(json.Trim());
                list.Add(instance);
            }

            ParquetConvert.Serialize(list, outPath, compressionMethod: CompressionMethod.Gzip);
        }
    }
}
