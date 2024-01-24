using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1.Models
{
    public class ProductService
    {
        public Product Detail(int id)
        {
            return this.List().First(x => x.id == 2);
        }

        public List<Product> List()
        {
            


            return new List<Product>()
            {
                new Product()
                {
                    id = 1,
                    name = "Car",
                    price = 152.24
                },
                new Product()
                {
                    id = 2,
                    name = "Bike",
                    price = 50.75
                },
                new Product()
                {
                    id = 3,
                    name = "Plane",
                    price = 1754.265
                }
                
            };
        }
    }
}
