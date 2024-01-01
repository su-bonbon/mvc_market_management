using Microsoft.AspNetCore.Mvc;

namespace WebApp.ViewComponents
{
	[ViewComponent]
	public class TransactionsViewComponent : ViewComponent
	{
		public string Invoke()
		{
			//return View("");
			return "List of Transactions";
		}
	}
}
