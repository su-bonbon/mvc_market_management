using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            return new ContentResult { Content = id.ToString() };
        }
    }
}
