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
    public class EFProductRepository : IProductRepository
    {
        private RetroShirtDBContext dbContext;

        public EFProductRepository(RetroShirtDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<int> Add(Product entity)
        {
            
            entity.CreatedTime = DateTime.Now;
            await dbContext.Products.AddAsync(entity);
            await dbContext.SaveChangesAsync();
            return entity.Id;
        }


        public async Task Delete(int id)
        {
            var product= await dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            product.IsActive = false;
            await dbContext.SaveChangesAsync();

        }

        public async Task<IList<Product>> GetAllEntities()
        {
            var productsList = await dbContext.Products.Include(p => p.Category)
                                                       .Include(z => z.Team)  
                                                       .Where(x=>x.IsActive==true)
                                                       .ToListAsync();
            return productsList;
        }

        public async Task<Product> GetEntityById(int id)
        {
            return await dbContext.Products.FindAsync(id);
        }

        public async Task<IList<Product>> GetProductsWithActiveStatus()
        {
            var productsList = await dbContext.Products.Include(p => p.Category)
                                                       .Include(z => z.Team)
                                                       .ToListAsync();
            return productsList;
        }

        public async Task<bool> IsExist(Product product)
        {
            return await dbContext.Products.AnyAsync(x => x.Name == product.Name);
        }

        public async Task RemoveProductCompletely(int id)
        {
            var deleteProduct= await dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            dbContext.Products.Remove(deleteProduct);
            await dbContext.SaveChangesAsync();           
                
        }

        public async Task<IList<Product>> SearchProducts(string searchKey)
        {

            return await dbContext.Products.Where(p => p.Name.Contains(searchKey) ||
                                                  p.Team.Name.Contains(searchKey) ||
                                                  p.Category.Name.Contains(searchKey)).ToListAsync();

        }

        public async Task<int> Update(Product entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
            entity.ModifiedDate = DateTime.Now;           
            dbContext.Update(entity);
            return await dbContext.SaveChangesAsync();
        }
    }
}
