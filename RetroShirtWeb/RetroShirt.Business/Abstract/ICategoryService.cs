using RetroShirtEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirt.Business.Abstract
{
    public interface ICategoryService
    {
        Task<IList<Category>> GetCategories();       
    }
}
