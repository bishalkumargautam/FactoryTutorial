using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using Types;


namespace FactoryBO
{
    public class EmplFacBO
    {
        public static IEmplBO CheckEmployee(string Username, string Password)
        {
            IEmplBO emplBO = new EmplBO(Username, Password);
            return emplBO;
        }
    }
}
