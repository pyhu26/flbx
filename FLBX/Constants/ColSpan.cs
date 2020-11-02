using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FLBX
{
    public class ColSpan
    {
        public ColSpan(int mdSpanValue, int? smSpanValue, int? lgSpanValue)
        {
            if (mdSpanValue <0 || mdSpanValue > 5)
                throw new ArgumentOutOfRangeException("mdSpanValue between 0~5");

            if (smSpanValue != null && (smSpanValue < 0 || smSpanValue > 5))
                throw new ArgumentOutOfRangeException("smSpanValue between 0~5");

            if (lgSpanValue != null && (lgSpanValue < 0 || lgSpanValue > 5))
                throw new ArgumentOutOfRangeException("lgSpanValue between 0~5");

            string cssColSpan = @"col-";
            this.ColSpanSMValue = cssColSpan + "sm-" + smSpanValue.ToString();
            this.ColSpanMDValue = cssColSpan + "md-" + mdSpanValue.ToString();
            this.ColSpanLGValue = cssColSpan + "lg-" + lgSpanValue.ToString();
            
        }

        public string ColSpanSMValue { get; set; }
        public string ColSpanMDValue { get; set; }
        public string ColSpanLGValue { get; set; }
    }
}
