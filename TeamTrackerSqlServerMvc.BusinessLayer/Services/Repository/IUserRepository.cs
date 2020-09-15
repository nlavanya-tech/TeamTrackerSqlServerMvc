using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamTrackerSqlServerMvc.DataLayer.Model;

namespace TeamTrackerSqlServerMvc.BusinessLayer.Services.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<TeamUser>> GetAllUserName();
        Task<IEnumerable<TeamUser>> UserReadAsync();
        Task<TeamUser> UserCreateAsync(TeamUser user);
        Task<TeamUser> UserUpdateAsync(TeamUser user);
        Task<bool> UserDeleteAsync(TeamUser user);
    }
}
