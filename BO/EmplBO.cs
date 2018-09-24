using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BO
{
    class EmplBO : IEmplBO
    {
        private string username;
        private string password;
        public string Username { get; set; }
        public string Password { get; set; }

        public EmplBO (string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
