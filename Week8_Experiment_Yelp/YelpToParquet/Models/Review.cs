using System;
using System.Collections.Generic;
using System.Text;

namespace YelpToParquet.Models
{
    class Review
    {
        public string business_id { get; set; }
        public string review_id { get; set; }
        public string user_id { get; set; }
        public double stars { get; set; }
        public long useful { get; set; }
        public long funny { get; set; }
        public long cool { get; set; }
        public string text { get; set; }
        public string date { get; set; }
    }
}
