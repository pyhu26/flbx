using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FLBX
{
    public class FLMessageSet
    {
        public MessageHeader FlMessageHeader { get; set; }
        public QueryMessage QueryMessage{ get; set; }
        public RuleMessage RuleMessage { get; set; }
        public EquipmentMessage EquipmentMessage { get; set; }
        public ReplyMessage ReplyMessage { get; set; }
    }
}
