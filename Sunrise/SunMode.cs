using System;
using System.Collections.Generic;
using System.Text;

namespace Sunrise
{
    class SunMode
    {
        public string Status { get; set; }
        public Results Results { get; set; }
    }

    public class Results
    {
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
    }
}
