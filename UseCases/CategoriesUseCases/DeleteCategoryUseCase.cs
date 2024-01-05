using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases.CategoriesUseCases
{
    public class DeleteCategoriesUseCases
    {
        private readonly ICategoryRepository categoryRepository;

        public DeleteCategoriesUseCases(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public void Execute(int categoryId)
        {
            categoryRepository.DeleteCategoty(categoryId);
        }
    }
}
