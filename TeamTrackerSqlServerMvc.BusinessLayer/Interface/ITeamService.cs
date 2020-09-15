using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamTrackerSqlServerMvc.DataLayer.Model;

namespace TeamTrackerSqlServerMvc.BusinessLayer.Interface
{
   public interface ITeamService
    {
        Task<IEnumerable<Team>> TeamReadAsync();
        Task<Team> TeamCreateAsync(Team teams);
        Task<Team> TeamUpdateAsync(Team teams);
        Task<bool> TeamDeleteAsync(Team teams);
    }
}
