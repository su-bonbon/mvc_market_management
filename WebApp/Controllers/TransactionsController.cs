using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
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

		public IActionResult Search(TransactionsViewModel transactionsViewModel)
		{
			var transactions = TransactionsRepository.Search(
				TransactionsViewModel.CashierName??string.Empty,
				TransactionsViewModel.StartDate,
				TransactionsViewModel.EndDate);

			transactionsViewModel.Transactions = transactions; 
			return View(transactionsViewModel);
		}
	}
}
