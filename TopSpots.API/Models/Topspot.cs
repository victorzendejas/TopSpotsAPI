using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TopSpots.API.Models
{
    public class Topspot
    {
        public string name { get; set; }
        public string description { get; set; }
        public decimal[] location { get; set; }
    }
}