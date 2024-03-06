using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Farragut.Core
{
    public class FeatureClass
    {
        public string Location { get; set; }
        public string Name { get; set; }
        public string Shapetype { get; set; }
        public Fields Fields { get; set; }
    }
}