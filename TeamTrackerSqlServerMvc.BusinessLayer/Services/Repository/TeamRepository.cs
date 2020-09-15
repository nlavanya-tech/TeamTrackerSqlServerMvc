using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamTrackerSqlServerMvc.DataLayer.Model;

namespace TeamTrackerSqlServerMvc.BusinessLayer.Services.Repository
{
    public class TeamRepository : ITeamRepository
    {
        private TeamTrackerDBContext _dbContext = new TeamTrackerDBContext();

        public async Task<IEnumerable<Team>> TeamReadAsync()
        {
            var teams = _dbContext.Teams.ToList();
            return teams;
        }
        //Add team into Inmemory Db and return teams
        public async Task<Team> TeamCreateAsync(Team teams)
        {
            _dbContext.Teams.Add(teams);
            _dbContext.SaveChanges();
            return teams;
        }
        //Update team into Inmemory Db and return teams 
        public async Task<Team> TeamUpdateAsync(Team teams)
        {
            var notes = _dbContext.Teams.FirstOrDefault(e => e.TeamName == teams.TeamName);
            if (notes != null)
            {
                teams.TeamName = teams.TeamName;
                teams.TeamMembers = teams.TeamMembers;
                teams.TeamManager = teams.TeamManager;
                _dbContext.SaveChanges();
            }
            else
            {
                teams = null;
            }
            return teams;
        }
        //Delete team from INmemory Db and return teams
        public async Task<bool> TeamDeleteAsync(Team teams)
        {
            Team team = _dbContext.Teams.Find(teams.TeamName);
            if (team != null)
            {
                _dbContext.Teams.Remove(team);
                _dbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
