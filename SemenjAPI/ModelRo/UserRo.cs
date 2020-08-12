using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SemenjAPI.ModelsRo
{
    public class UserRo
    {
        public UserRo () {}
        public UserRo(string message, string username, string password, string error)
        {
            Message = message;
            Username = username;
            Password = password;
            Error = error;
        }

        public string Message { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Error { get; set; }
    }
}
