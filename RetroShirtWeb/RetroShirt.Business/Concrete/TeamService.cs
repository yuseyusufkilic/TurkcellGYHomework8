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
    public class TeamService : ITeamService
    {
        private ITeamRepository teamRepository;

        public TeamService(ITeamRepository teamRepository)
        {
            this.teamRepository = teamRepository;
        }

        public async Task<int> AddTeam(Team team)
        {
            return await teamRepository.Add(team);
        }

        public async Task<IList<Team>> GetTeams()
        {
            return await teamRepository.GetAllEntities();
        }

        public async Task<bool> TeamIsExist(Team team)
        {
            return await teamRepository.IsExist(team);
        }
    }
}
