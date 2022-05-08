using Microsoft.EntityFrameworkCore;
using RetroShirtDAL.Data;
using RetroShirtEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirtDAL.Repositories
{
    public class EFCategoryRepository : ICategoryRepository
    {
        private RetroShirtDBContext dBContext;

        public EFCategoryRepository(RetroShirtDBContext dBContext)
        {
            this.dBContext = dBContext;   
        }
        public async Task<int> Add(Category entity)
        {
            await dBContext.Categories.AddAsync(entity);
            await dBContext.SaveChangesAsync();
            return entity.CategoryId;
        }

        public async Task Delete(int id)
        {
            var deleteCategory  = await dBContext.Categories.FirstOrDefaultAsync(x => x.CategoryId == id);
            dBContext.Categories.Remove(deleteCategory);
            await dBContext.SaveChangesAsync();
        }

        public async Task<IList<Category>> GetAllEntities()
        {
            return await dBContext.Categories.ToListAsync();
        }

        public async Task<Category> GetEntityById(int id)
        {
            return await dBContext.Categories.FindAsync(id);
        }

        public async Task<bool> IsExist(Category category)
        {
            return await dBContext.Categories.AnyAsync(x => x.Name == category.Name);
        }

        public async Task<IList<Category>> SearchByCategoryName(string name)
        {
            return await dBContext.Categories.Where(p => p.Name.Contains(name)).ToListAsync();
        }

        public Task<int> Update(Category entity)
        {
            dBContext.Categories.Update(entity);
            return dBContext.SaveChangesAsync();
            
        }
    }
}
