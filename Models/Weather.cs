using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_API.Models
{
    public class Weather
    {
        public string City { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string Temperature { get; set; }

        public string Low { get; set; }

        public string High { get; set; }

        public string FeelsLike { get; set; }

        public string Wind { get; set; }

        public string Clouds { get; set; }
    }
}
