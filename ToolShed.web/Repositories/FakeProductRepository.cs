using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToolShed.web.Models;

namespace ToolShed.web.Repositories
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product>
        {
            new Product {Name = "Philips 50-tum 4K UHD Smart-TV", Price = 25000, Description = "Dunderbra TV du kommer älska den"},
            new Product {Name = "TCL 40-tum Full Hd Smart TV", Price = 25000, Description = "Dunderbra TV du kommer älska den"},
            new Product {Name = "LG 49-tum UHD Smart TV", Price = 25000, Description = "Dunderbra TV du kommer älska den"},
            new Product {Name = "Samsung 55-tum 4K TV", Price = 25000, Description = "Dunderbra TV du kommer älska den"}
        };
    }
}
