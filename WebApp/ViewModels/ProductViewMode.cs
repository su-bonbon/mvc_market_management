using WebApp.Models;

namespace WebApp.ViewModels
{
    public class ProductViewMode
    {
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();
        public Product Product { get; set; } = new Product();
    }
}
