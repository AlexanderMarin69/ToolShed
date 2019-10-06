using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToolShed.web.Models;

namespace ToolShed.web.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
