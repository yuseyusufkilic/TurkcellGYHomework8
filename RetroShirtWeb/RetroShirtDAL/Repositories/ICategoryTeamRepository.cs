using RetroShirtEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirtDAL.Repositories
{
    public interface ICategoryTeamRepository
    {
        public Task addMany2Many(Product product, CategoryTeam categoryTeam);

    }
}
