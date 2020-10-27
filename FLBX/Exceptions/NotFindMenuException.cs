using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace FLBX
{
    /// <summary>
    /// 메뉴 Id로 등록된 메뉴를 DB에서 못찾을 경우, 발생하는 Exception
    /// </summary>
    [Serializable]
    public class NotFindMenuException : Exception
    {
        public NotFindMenuException(string message) : base(message)
        {
        }
    }
}
