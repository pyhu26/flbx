using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace FLBX
{
    /// <summary>
    /// Configure 구성이 이뤄지지 않은 경우, 발생하는 Exception
    /// </summary>
    [Serializable]
    public class NotImplementConfigureException : Exception
    {
        public NotImplementConfigureException(string message) : base(message)
        {

        }
    }
}
