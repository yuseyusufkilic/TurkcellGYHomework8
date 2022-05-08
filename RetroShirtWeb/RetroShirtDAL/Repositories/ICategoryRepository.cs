using RetroShirtEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirtDAL.Repositories
{
    public interface ICategoryRepository: IRepository<Category>
    {
        Task<IList<Category>> SearchByCategoryName(string name);
        
    }
}
