using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Core.Model
{
   public class CityModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public CoordinateModel Coord { get; set; }

        public string Country { get; set; }

        public long Population { get; set; }
    }
}
