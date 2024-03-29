﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToolShed.web.Repositories;
using ToolShed.web.ViewModels;

namespace ToolShed.web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repo;
        public int PageLimit = 4;
        
        public ProductController(IProductRepository productRepository)
        {
            repo = productRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(int page = 1)
        {
            var toSkip = (page - 1) * PageLimit;

            var products = repo.Products.OrderBy(x => x.Id).Skip(toSkip).Take(PageLimit);
            var paging = new PagingInfo { CurrentPage = page, ItemsPerPage = PageLimit, TotalItems = repo.Products.Count() };
            var vm = new ProductListViewModel { Products = products, Pager = paging };
            return View(vm);
        }
    }
}