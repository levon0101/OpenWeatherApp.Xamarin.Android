using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Core.Model
{
    public class SysModel
    {
        public int Type { get; set; }

        public int Id { get; set; }

        public double Message { get; set; }

        public string Country { get; set; }

        public long Sunrise { get; set; }

        public long Sunset { get; set; }
        
    }
}
