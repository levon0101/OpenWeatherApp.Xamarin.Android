using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Weather.Core.Model
{
    public class ForcastWeatherModel
    {
        public long dt { get; set; }

        public MainModel Main { get; set; }

        public List<WeatherModel> Weather { get; set; } // all ok

        public CloudModel Clouds { get; set; }

        public WindModel Wind { get; set; }

        public SnowModel Snow { get; set; }

        [JsonProperty(PropertyName = "dt_txt")]
        public DateTime dateTime {get; set; }
    }
}
