using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamTrackerSqlServerMvc.BusinessLayer.Interface;
using TeamTrackerSqlServerMvc.BusinessLayer.Services.Repository;
using TeamTrackerSqlServerMvc.DataLayer.Model;

namespace TeamTrackerSqlServerMvc.BusinessLayer.Services
{
    public class TeamService : ITeamService
    {
        //create local instance 
        private readonly ITeamRepository _repositary;

        public TeamService(ITeamRepository repositary)
        {
            _repositary = repositary;
        }

        //Get teams and retrun list of teams
        public async Task<IEnumerable<Team>> TeamReadAsync()
        {
            var teams = await _repositary.TeamReadAsync();
            return teams;
        }
        //Create teams
        public async Task<Team> TeamCreateAsync(Team teams)
        {
            await _repositary.TeamCreateAsync(teams);
            return teams;
        }
        //Update teams
        public async Task<Team> TeamUpdateAsync(Team teams)
        {
            var note = await _repositary.TeamUpdateAsync(teams);

            return note;
        }
        //Delete teams 
        public async Task<bool> TeamDeleteAsync(Team teams)
        {
            var result = await _repositary.TeamDeleteAsync(teams);
            return result;
        }
    }
}
