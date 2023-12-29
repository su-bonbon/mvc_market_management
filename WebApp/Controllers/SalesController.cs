﻿using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            var salesViewModel = new SalesViewModel
            {
                Categories = CategoriesRepository.GetCategories()
            };
            return View(salesViewModel);
        }

        public IActionResult SellProductPatial(int productId)
        {
            var product = ProductsRepository.GetProductById(productId);
            return PartialView("_SellProduct", product);
        }
    }
}
