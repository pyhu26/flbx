using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FLBX
{
    public class RuleMessage
    {
        public string RuleName { get; set; }
        public Dictionary<string, object> ParmeterKeyValues { get; set; }
    }
}
