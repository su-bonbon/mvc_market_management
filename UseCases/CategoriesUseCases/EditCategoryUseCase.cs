using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases.CategoriesUseCases
{
    public class EditCategoriesUseCases
    {
        private readonly ICategoryRepository categoryRepository;

        public EditCategoriesUseCases(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public void Execute(int categoryId, Category category)
        {
            categoryRepository.UpdateCategory(categoryId, category);
        }
    }
}
