using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FLBX.Components
{
    public partial class FxFilterButtons
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
