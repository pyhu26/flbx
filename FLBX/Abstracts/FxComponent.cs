using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FLBX
{
    public class AbstractFxFilter : IFxComponent
    {
        public AbstractFxFilter(ColSpan colSpan)
        {
            this.ColSpanValue = colSpan;
        }
        
        public ColSpan ColSpanValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string AuthorityLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void GetValue()
        {
            throw new NotImplementedException();
        }

        public void SetAuthority()
        {
            throw new NotImplementedException();
        }

        public void SetRegion()
        {
            throw new NotImplementedException();
        }
    }
}
