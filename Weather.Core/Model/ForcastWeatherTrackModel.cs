using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Core.Model
{
    public class ForcastWeatherTrackModel
    {
        public int Cod { get; set; }

        public double Message { get; set; }


        [JsonProperty(PropertyName = "cnt")]
        public int Count { get; set; }


        public List<ForcastWeatherModel> list { get; set; }


        public CityModel City { get; set; }
    }
}
