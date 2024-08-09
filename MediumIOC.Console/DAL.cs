using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumIOC.Console
{
    internal class DAL
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 10, Stock = 100 },
                new Product { Id = 2, Name = "Product 2", Price = 20, Stock = 200 },
                new Product { Id = 3, Name = "Product 3", Price = 30, Stock = 300 },
                new Product { Id = 4, Name = "Product 4", Price = 40, Stock = 400 },
                new Product { Id = 5, Name = "Product 5", Price = 50, Stock = 500 }
            };
        }   
    }
}
