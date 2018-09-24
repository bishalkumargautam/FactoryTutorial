using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using BLL;

namespace FactoryBLL
{
   public class EmplFacBLL
    {
        public static IEmplBLL createnew()
        {
            IEmplBLL objemplBLL = new EmplBLL();
            return objemplBLL;
                
        }
    }
}
