using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FLBX
{
    public class EquipmentMessage
    {
        public string RuleName { get; set; }
        public string RecipeId { get; set; }
        public string EquipmentId { get; set; }
        public string LotId { get; set; }
        public string LotType { get; set; }
        public string Location { get; set; }
		public Dictionary<string, object> ParameterKeyValues { get; set; }
    }
}
