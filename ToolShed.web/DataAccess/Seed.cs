using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToolShed.web.Models;

namespace ToolShed.web.DataAccess
{
    public static class Seed
    {
        internal static void FillIfEmpty(ApplicationDbContext ctx)
        {
            if (!ctx.Categories.Any())
            {
                ctx.Categories.Add(new Category { Name = "Ljud & bild" });
                ctx.Categories.Add(new Category { Name = "Telefoni" });
                ctx.Categories.Add(new Category { Name = "Datorer" });
                ctx.Categories.Add(new Category { Name = "Tillbehör" });
                ctx.Categories.Add(new Category { Name = "Spel & konsoller" });
                ctx.SaveChanges();
            }

            if (!ctx.Products.Any())
            {
                var products = new List<Product>
                {
                    //Ljud & bild
                    new Product {Name = "Philips 50-tum 4K UHD Smart-TV", Price = 25000, Description = "Dunderbra TV du kommer älska den", CategoryId = 1 },
                    new Product {Name = "TCL 40-tum Full Hd Smart TV", Price = 25000, Description = "Dunderbra TV du kommer älska den", CategoryId = 1 },
                    new Product {Name = "LG 49-tum UHD Smart TV", Price = 25000, Description = "Dunderbra TV du kommer älska den", CategoryId = 1 },
                    new Product {Name = "Samsung 55-tum 4K TV", Price = 25000, Description = "Dunderbra TV du kommer älska den", CategoryId = 1 },

                    //Telefoni
                    new Product {Name = "Iphone 11 Pro", Price = 25000, Description = "Dunderbra TV du kommer älska den", CategoryId = 2 },
                    new Product {Name = "Huawei P20 Pro", Price = 25000, Description = "Dunderbra TV du kommer älska den", CategoryId = 2 },
                    new Product {Name = "Samsung Galaxy S10", Price = 25000, Description = "Dunderbra TV du kommer älska den", CategoryId = 2 },
                    new Product {Name = "Nokia 3310", Price = 25000, Description = "Dunderbra TV du kommer älska den", CategoryId = 2 },

                    new Product {Name = "Microsoft Surface Laptop", Price = 25000, Description = "Dunderbra TV du kommer älska den", CategoryId = 3 },
                    new Product {Name = "Acer Chromebook", Price = 25000, Description = "Dunderbra TV du kommer älska den", CategoryId = 3 },
                    new Product {Name = "HP Probook", Price = 25000, Description = "Dunderbra TV du kommer älska den", CategoryId = 3 },
                    new Product {Name = "Lenovo Ideapad S130", Price = 25000, Description = "Dunderbra TV du kommer älska den", CategoryId = 3 },

                    new Product {Name = "Logitech tangentbord", Price = 25000, Description = "Dunderbra TV du kommer älska den", CategoryId = 4 },
                    new Product {Name = "Kingston Flashdrive 64GB", Price = 25000, Description = "Dunderbra TV du kommer älska den", CategoryId = 4 },
                    new Product {Name = "Logitech trådlöst gaming headset", Price = 25000, Description = "Dunderbra TV du kommer älska den", CategoryId = 4 },
                    

                    new Product {Name = "Call Of Duty Black Ops 4", Price = 25000, Description = "Dunderbra TV du kommer älska den", CategoryId = 5 },
                    new Product {Name = "Grand Theft Auto VI", Price = 25000, Description = "Dunderbra TV du kommer älska den", CategoryId = 5 },
                    new Product {Name = "Minecraft", Price = 25000, Description = "Dunderbra TV du kommer älska den", CategoryId = 5 },
                    new Product {Name = "In Justice 2", Price = 25000, Description = "Dunderbra TV du kommer älska den", CategoryId = 5 },
                };

                ctx.Products.AddRange(products);
                ctx.SaveChanges();

            }
        }
    }
}
