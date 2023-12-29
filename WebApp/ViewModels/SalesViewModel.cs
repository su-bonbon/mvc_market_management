using WebApp.Models;

namespace WebApp.ViewModels
{
	public class SalesViewModel
	{
		public int SelectedCategoryId { get; set; }
		public IEnumerable<Category> Categories { get; set; } = new List<Category>();

		public int SelectedProductId { get; set; }

		public int QuantityToSell { get; set; }
	}
}
