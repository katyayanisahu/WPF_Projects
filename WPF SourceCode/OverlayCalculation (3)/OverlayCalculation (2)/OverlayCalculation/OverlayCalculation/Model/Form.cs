using ArcGIS.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Farragut.Core
{
    public class Form
    {
        public string OverlayFeatureClasses { get; set; }
        public string Name { get; set; }
        public List<FeatureClass> FeatureClass { get; set; }
    }
}