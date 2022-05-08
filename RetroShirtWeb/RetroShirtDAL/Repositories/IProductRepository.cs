using RetroShirtEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirtDAL.Repositories
{
    public interface IProductRepository:IRepository<Product>
    {
        Task<IList<Product>> SearchProducts(string searchKey);
        Task<IList<Product>> GetProductsWithActiveStatus();
        Task RemoveProductCompletely(int id);

    }
}
