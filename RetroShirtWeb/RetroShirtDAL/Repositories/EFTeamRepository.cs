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
    public class EFTeamRepository : ITeamRepository
    {
        private RetroShirtDBContext dBContext;

        public EFTeamRepository(RetroShirtDBContext dBContext)
        {
            this.dBContext=dBContext;
        }
        public async Task<int> Add(Team entity)
        {
            await dBContext.Teams.AddAsync(entity);
            await dBContext.SaveChangesAsync();
            return entity.TeamId;
        }

        public async Task Delete(int id)
        {

            var team=await dBContext.Teams.FirstOrDefaultAsync(x => x.TeamId == id);
            dBContext.Teams.Remove(team);
        }

        public async Task<IList<Team>> GetAllEntities()
        {
            return await dBContext.Teams.ToListAsync();
        }

        public async Task<Team> GetEntityById(int id)
        {
            return await dBContext.Teams.FindAsync(id);
        }

        public async Task<bool> IsExist(Team entity)
        {
            return await dBContext.Teams.AnyAsync(p => p.Name==entity.Name);
        }

        public Task<int> Update(Team entity)
        {
            dBContext.Teams.Update(entity);
            return dBContext.SaveChangesAsync();
        }
    }
}
