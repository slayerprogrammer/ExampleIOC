using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumIOC.Console
{
    internal class BL
    {
        private readonly IDAL _dal;

        public BL(IDAL dal)
        {
            _dal = dal;
        }

        public List<Product> GetProducts()
        {
            return _dal.GetProducts();
        }
    }
}
