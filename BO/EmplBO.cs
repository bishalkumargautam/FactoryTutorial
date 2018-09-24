using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BO
{
     public class EmplBO : IEmplBO
    {
      
        public string Username { get; set; }
        public string Password { get; set; }

        public EmplBO(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
