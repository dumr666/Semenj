using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SemenjAPI.ModelRo
{
    public class SessionRo
    {
        public SessionRo() { }
        public SessionRo(Guid sid, string message, string error, DateTime loginTime )
        {
            Sid = sid;
            Message = message;
            Error = error;
            LoginTime = loginTime;
        }

        public Guid Sid { get; set; }
        public string Message { get; set; }
        public string Error { get; set; }
        public DateTime LoginTime { get; set; }

    }
}
