using RetroShirtEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirtDAL.Repositories
{
    public interface IRepository<T> where T : class,IEntity, new()
    {
        Task<IList<T>> GetAllEntities();
        Task<T> GetEntityById(int id);

        Task<int> Add(T entity);
        Task<int> Update(T entity);
        Task Delete(int id);
        Task<bool> IsExist(T entity);
        
    }
}
