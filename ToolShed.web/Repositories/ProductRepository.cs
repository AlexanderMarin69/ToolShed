using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToolShed.web.DataAccess;
using ToolShed.web.Models;

namespace ToolShed.web.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext ctx;

        public ProductRepository(ApplicationDbContext context)
        {
            ctx = context;
        }
        public IEnumerable<Product> Products => ctx.Products;
    }
}
