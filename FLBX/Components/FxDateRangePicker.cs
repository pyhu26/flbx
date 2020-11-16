using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Calendars;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace FLBX.Components
{
    public partial class FxDateRangePicker : IFxComponent
    {
        public SfDateRangePicker sfDateRangePicker { get; set; }
        
        [Parameter]
        public string Placeholder { get; set; }

        [Parameter]
        public int SmallColSpanValue { get; set; }
        [Parameter]
        [NotNull]
        public int MediumColSpanValue { get; set; }
        [Parameter]
        public int LargeColSpanValue { get; set; }

        [Parameter]
        public DateTime StartDate { get; set; }
        [Parameter]
        public DateTime EndDate { get; set; }

        [Parameter]
        public EventCallback OnValueChanged { get; set; }

        public string cssClass { get; set; }

        [Parameter]
        public EventCallback Onclose { get; set; }

        public void ValuechangeHandler(ChangedEventArgs<DateTime?> args)
        {
            OnValueChanged.InvokeAsync(args);
        }

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

        public void GetValue()
        {
            
        }

        public Dictionary<string, object> GetKeyValues()
        {
            return new Dictionary<string, object>() {
                { "StartDate" , this.sfDateRangePicker.StartDate },
                { "EndDate", this.sfDateRangePicker.EndDate}
            };
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
