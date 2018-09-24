using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using DAL;

namespace FactoryDAL
{
     public class EmplFacDAL
    {
        public static IEmplDAL createDal()
        {
            IEmplDAL emplDAL = new EmplDAL();
            return emplDAL;
        }
    }
}
