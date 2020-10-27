using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FLBX
{
    public class Menu
    {
        [JsonPropertyName("menuId")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("level")]
        public int Level { get; set; }
        [JsonPropertyName("parent")]
        public string Parent { get; set; }
        [JsonPropertyName("depth")]
        public string Depth { get; set; }
        [JsonPropertyName("seq")]
        public int DisplaySeq { get; set; }
        [JsonPropertyName("page")]
        public string Page { get; set; }

        [Parameter]
        public RenderFragment Component { get; set; }
        public string IsVisible { get; set; }
        public string TabHeaderCss => IsVisible == "visible" ? "nav-link active" : "nav-link";
    }
}
