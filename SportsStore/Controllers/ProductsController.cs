﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Services;

namespace SportsStore.Controllers
{
    public class ProductsController : Controller
    {
        IBrowsingAppService _browsingAppService;

        public ProductsController(IBrowsingAppService browsingAppService)
        {
            _browsingAppService = browsingAppService;
        }

        public IActionResult Index(string categoryName)
        {
            var products = _browsingAppService.GetProducts(new Services.Models.GetProductsRequest
            {
                CategoryName = categoryName
            });

            return View(products);
        }
    }
}