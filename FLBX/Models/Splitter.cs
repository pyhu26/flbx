using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FLBX
{
    public class Splitter
    {
        public string size { get; set; }
        public string min { get; set; }
        public string cssClass { get; set; }
        public string title { get; set; }
        public RenderFragment contentTemplate { get; set; }
    }
}
