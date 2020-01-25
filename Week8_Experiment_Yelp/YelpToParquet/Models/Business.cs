using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace YelpToParquet.Models
{
    public class Business
    {
        public string business_id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postal_code { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double stars { get; set; }
        public long review_count { get; set; }
        public long is_open { get; set; }
        //public JToken attributes { get; set; }
        public string categories { get; set; }
        //public string hours { get; set; }
    }
}
