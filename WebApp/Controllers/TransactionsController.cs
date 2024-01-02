using Microsoft.AspNetCore.Mvc;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
	public class TransactionsController : Controller
	{
		public IActionResult Index()
		{
			TransactionsViewModel transactionsViewModel = new TransactionsViewModel();
			return View(transactionsViewModel);
		}
	}
}
