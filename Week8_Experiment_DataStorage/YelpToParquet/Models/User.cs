using System;
using System.Collections.Generic;
using System.Text;

namespace YelpToParquet.Models
{
    class User
    {
        public string user_id { get; set; }
        public string name { get; set; }
        public long review_count { get; set; }
        public string yelping_since { get; set; }
        public long useful { get; set; }
        public long funny { get; set; }
        public long cool { get; set; }
        public string elite { get; set; }
        public string friends { get; set; }
        public long fans { get; set; }
        public double average_stars { get; set; }
        public long compliment_hot { get; set; }
        public long compliment_more { get; set; }
        public long compliment_profile { get; set; }
        public long compliment_cute { get; set; }
        public long compliment_list { get; set; }
        public long compliment_note { get; set; }
        public long compliment_plain { get; set; }
        public long compliment_cool { get; set; }
        public long compliment_funny { get; set; }
        public long compliment_writer { get; set; }
        public long compliment_photos { get; set; }
    }
}
