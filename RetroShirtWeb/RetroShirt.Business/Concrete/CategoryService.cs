using RetroShirt.Business.Abstract;
using RetroShirtDAL.Repositories;
using RetroShirtEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirt.Business.Concrete
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public async Task<IList<Category>> GetCategories()
        {
            return await categoryRepository.GetAllEntities();
        }
    }
}
