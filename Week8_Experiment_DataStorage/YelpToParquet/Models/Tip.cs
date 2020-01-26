using System;
using System.Collections.Generic;
using System.Text;

namespace YelpToParquet.Models
{
    class Tip
    {
        public string business_id { get; set; }
        public string user_id { get; set; }
        public string text { get; set; }
        public string date { get; set; }
        public long compliment_count { get; set; }
    }
}
