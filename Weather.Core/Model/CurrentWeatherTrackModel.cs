using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Core.Model
{
    public class CurrentWeatherTrackModel
    {
        public CoordinateModel Coord { get; set; }

        public List<WeatherModel> Weather { get; set; }

        public string Base { get; set; }

        public MainModel Main { get; set; }

        public int Visibility { get; set; }

        public WindModel Wind { get; set; }

        public CloudModel Clouds { get; set; }

        public long Dt { get; set; }

        public SysModel Sys { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Cod { get; set; }

    }
}
