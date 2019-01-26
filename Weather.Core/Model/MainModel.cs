using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Core.Model
{
    public class MainModel
    {
        public double Temp { get; set; }

        public double Pressure { get; set; }

        public int Humidity { get; set; }


        [JsonProperty(PropertyName = "temp_min")]
        public double TempMin { get; set; }

        [JsonProperty(PropertyName = "temp_max")]
        public double TempMax { get; set; }
    }
}
