using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FLBX
{
    public class MessageHeader
    {
        public string TargetSystem { get; set; }
        public string SourceSystem { get; set; }
        public string MessageType { get; set; }
        public string SiteId { get; set; }
        public string UserId { get; set; }
        public string SecretToken { get; set; }
        public string TargetUrl { get; set; }
        public string Tid { get; set; }
		public string TimeStamp { get; set; }
        public string SourceIpAddress { get; set; }
        public string Language { get; set; }
		public string Encoding { get; set; }
		public string CommunicatoinType { get; set; }
        public Dictionary<string, object> ParameterKeyValues { get; set; }
    }
}
