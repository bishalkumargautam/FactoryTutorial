﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using FactoryDAL;

namespace BLL
{
   public  class EmplBLL : IEmplBLL
    {
        public int CheckEmp(IEmplBO emplBO)
        {
            IEmplDAL obj1 = EmplFacDAL.createDal();
            return (obj1.CheckEmployee(emplBO));
        }
    }
}
