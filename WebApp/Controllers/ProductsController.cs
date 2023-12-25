using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
	public class ProductsController : Controller
	{
		public IActionResult Index()
		{
			var products = ProductsRepository.GetProducts(loadCategory: true);
			return View(products);
		}

		public IActionResult Add()
		{
			var productViewModel = new ProductViewModel
			{
				Categories = CategoriesRepository.GetCategories()
			};

			return View(productViewModel);
		}
	}
}
