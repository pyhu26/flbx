﻿using FLBX.Models;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.DropDowns;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace FLBX.Components
{
    public partial class FxDropDown : ComponentBase,  IFxComponent
    {
        public SfDropDownList<string, DropDownModel> sfDropDownList { get; set; }

        [Parameter]
        public IEnumerable<DropDownModel> DataSourceValue { get; set; }

        [Parameter]
        public string PopupHeight { get; set; }

        [Parameter]
        public string PopupWidth { get; set; } = "500px";

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
        public bool IsMandantory { get; set; }

        [Parameter]
        public string InnerCssClass { get; set; } = "e-multi-column";

        public string cssClass { get; set; }

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
            
            cssClass = css;

            if (IsMandantory)
            {
                InnerCssClass += " e-success";
            }
        }

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
