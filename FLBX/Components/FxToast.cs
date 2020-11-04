using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace FLBX.Components
{
    public partial class FxToast : IFxComponent
    {
        public SfToast fxToast { get; set; }

        [Parameter]
        public int SmallColSpanValue { get; set; }

        [Parameter]
        [NotNull]
        public int MediumColSpanValue { get; set; }
        [Parameter]
        public int LargeColSpanValue { get; set; }

        public string cssClass { get; set; }

        [Parameter]
        public string ToastContent { get; set; }
        [Parameter]
        public int ToastTimeOut { get; set; }
        [Parameter]
        public string ToastTitle { get; set; }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            string css = "";
            if (SmallColSpanValue is int i && i >= 0 && i < 13)
                css += "col-sm-" + SmallColSpanValue.ToString();

            if (MediumColSpanValue is int j && j >= 0 && j < 13)
            {
                css += " ";
                css += "col-md-" + MediumColSpanValue.ToString();
            }

            if (LargeColSpanValue is int k && k >= 0 && k < 13)
            {
                css += " ";
                css += "col-lg-" + LargeColSpanValue.ToString();
            }

            this.cssClass = css;

            StateHasChanged();
        }

        public string AuthorityLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ColSpan ColSpanValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
