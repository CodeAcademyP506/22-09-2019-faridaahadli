using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toDoList
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public  UInt64 Id { get; set; }
        public static UInt64 i = 0;
        public User(string _username, string _password)
        {

            this.Username = _username;
            this.Password = _password;
            this.Id=i++;
        }
    }
}
