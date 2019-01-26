using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Core.Model
{
    public class WeatherModel
    {
        public int Id { get; set; }

        public string Main { get; set; }

        public string Description { get; set; }

        public string Icon { get; set; }

    }
}
