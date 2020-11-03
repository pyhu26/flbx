using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FLBX
{
    public class AbstractFxFilter 
    {
        public AbstractFxFilter(ColSpan colSpan)
        {
            this.ColSpanValue = colSpan;
        }
        
        public ColSpan ColSpanValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        
    }
}
