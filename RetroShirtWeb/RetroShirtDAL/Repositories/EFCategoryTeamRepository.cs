using RetroShirtDAL.Data;
using RetroShirtEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirtDAL.Repositories
{
    public class EFCategoryTeamRepository : ICategoryTeamRepository
    {
        private RetroShirtDBContext dbContext;

        public EFCategoryTeamRepository(RetroShirtDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task addMany2Many(Product product, CategoryTeam categoryTeam)
        {
            categoryTeam.Team = product.Team;
            categoryTeam.Category = product.Category;
            await dbContext.CategoryTeams.AddAsync(categoryTeam);
            await dbContext.SaveChangesAsync();
        }
    }
}
