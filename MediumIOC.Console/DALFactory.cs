﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumIOC.Console
{
    internal class DALFactory
    {
        public static IDAL GetDAL()
        {
            return new DAL();
        }
    }
}
