using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTO
{
    public class UserDTO
    {
        private string _username;
        private string _password;

        public UserDTO(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public string UserName { get { return _username; } }
        public string Password { get { return _password;} }
    }
}
