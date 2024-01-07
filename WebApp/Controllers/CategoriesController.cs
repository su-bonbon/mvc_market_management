using Microsoft.AspNetCore.Mvc;
using UseCases.CategoriesUseCases;
using WebApp.Models;
using CoreBusiness;

namespace WebApp.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IViewCategoriesUseCase viewCategoriesUseCase;

        public CategoriesController(
            IViewCategoriesUseCase viewCategoriesUseCase,
            IViewSelectedCategoryUseCase viewSelectedCategoryUseCase,
            IEditCategoryUseCase editCategoryUseCase,
            IAddCategoryUseCase addCategoryUseCase,
            IDeleteCategoryUseCase deleteCategoryUseCase)
        {
            this.viewCategoriesUseCase = viewCategoriesUseCase;
            this.viewSelectedCategoryUseCase = viewSelectedCategoryUseCase;
            this.editCategoryUseCase = editCategoryUseCase;
            this.addCategoryUseCase = addCategoryUseCase;
            this.deleteCategoryUseCase = deleteCategoryUseCase;
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
            var category = viewSelectedCategoryUseCase.Execute(id.HasValue ? id.Value : 0);
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                editCategoryUseCase.Execute(category.CategoryId, category);
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
                addCategoryUseCase.Execute(category);
                return RedirectToAction(nameof(Index));
			}
			ViewBag.Action = "add";
			return View(category);
		}

		[HttpGet]
		public IActionResult Delete(int categoryId)
        {
            deleteCategoryUseCase.Execute(categoryId);
            return RedirectToAction(nameof(Index));
        }
	}
}
