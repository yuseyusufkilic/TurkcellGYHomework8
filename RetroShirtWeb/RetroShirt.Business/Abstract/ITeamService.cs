using RetroShirtEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirt.Business.Abstract
{
    public interface ITeamService
    {
        Task<IList<Team>> GetTeams();       
        Task<int> AddTeam(Team team);        
        Task<bool> TeamIsExist(Team team);
    }
}
