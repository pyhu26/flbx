using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FLBX
{
    public class ReplyMessage
    {
        public bool IsSuccess { get; set; }
        public string ExceptionMessage { get; set; }
        public Dictionary<string, object> ResultKeyValues { get; set; }
    }
}
