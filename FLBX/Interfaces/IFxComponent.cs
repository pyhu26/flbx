using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FLBX
{
    public interface IFxComponent
    {

        public string AuthorityLevel { get; set; }
        public ColSpan ColSpanValue { get; set; }
        public void GetValue();
        public void SetRegion();
        public void SetAuthority();
            
    }
}
