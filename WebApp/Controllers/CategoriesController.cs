using Microsoft.AspNetCore.Mvc;
using UseCases.CategoriesUseCases;
using CoreBusiness;
using Microsoft.AspNetCore.Authorization;

namespace WebApp.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IViewCategoriesUseCase viewCategoriesUseCase;

        public CategoriesController(IViewCategoriesUseCase viewCategoriesUseCase) 
        {
            this.viewCategoriesUseCase = viewCategoriesUseCase;
        }
        public IActionResult Index()
        {
            var categories = viewCategoriesUseCase.Execute();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Edit([FromRoute]int? id)
        {
            ViewBag.Action = "edit";
            var category = CategoriesRepository.GetCategoryById(id.HasValue? id.Value : 0);
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
				CategoriesRepository.UpdateCategory(category.CategoryId, category);
				return RedirectToAction(nameof(Index));
			}
			ViewBag.Action = "edit";
			return View(category);
        }

		[HttpGet]
		public IActionResult Add()
		{
            ViewBag.Action = "add";
			return View();
		}

		[HttpPost]
		public IActionResult Add([FromForm]Category category)
		{
			if (ModelState.IsValid)
			{
				CategoriesRepository.AddCategory(category);
				return RedirectToAction(nameof(Index));
			}
			ViewBag.Action = "add";
			return View(category);
		}

		[HttpGet]
		public IActionResult Delete(int categoryId)
        {
            CategoriesRepository.DeleteCategory(categoryId);
            return RedirectToAction(nameof(Index));
        }
	}
}
