using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toDoList
{
    class ToDo
    {
        public static UInt64 i = 0;
        public UInt64 Id { get; set; }
        public string Title { get; set; }
        public User User { get; set; }
        public ToDo(string _title,User _user)
        {
            
            this.Title = _title;
            this.User = _user;
            this.Id = i++;
        }
    }
}
