using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FLBX
{
    public class QueryMessage
    {
        public string QueryId { get; set; }
        public string QueryType { get; set; }
        public string QueryVersion { get; set; }
        public string SiteId { get; set; }
        public Dictionary<string,object> ParameterKeyValue { get; set; }
    }
}
