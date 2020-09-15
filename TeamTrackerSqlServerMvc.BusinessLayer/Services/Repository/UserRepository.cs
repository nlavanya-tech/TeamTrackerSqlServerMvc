using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamTrackerSqlServerMvc.DataLayer.Model;

namespace TeamTrackerSqlServerMvc.BusinessLayer.Services.Repository
{
    public class UserRepository : IUserRepository
    {
        private TeamTrackerDBContext _dbContext = new TeamTrackerDBContext();

        //Get All UserNames
        public async Task<IEnumerable<TeamUser>> GetAllUserName()
        {
            var users = _dbContext.TeamUsers.ToList();
            //  IList<Users> userlist = new List<Users>();
            //string userlist = "";
            //foreach (var user in users)
            //{
            //    userlist.Add();

            //}
            return users;
        }
        //Get All Users details
        public async Task<IEnumerable<TeamUser>> UserReadAsync()
        {
            var users = _dbContext.TeamUsers.ToList();
            return users;
        }
        //Add user into Inmemory Db and return user
        public async Task<TeamUser> UserCreateAsync(TeamUser users)
        {
            _dbContext.TeamUsers.Add(users);
            _dbContext.SaveChanges();
            return users;
        }
        //Update user into Inmemory Db and return user 
        public async Task<TeamUser> UserUpdateAsync(TeamUser user)
        {
            var users = _dbContext.TeamUsers.FirstOrDefault(e => e.LastName == user.LastName);
            if (users != null)
            {
                users = user;
                users.FirstName = users.FirstName;
                users.LastName = users.LastName;
                users.Mobile = users.Mobile;
                users.ReportingTo = users.ReportingTo;
                users.Status = users.Status;
                users.UserType = users.UserType;
                _dbContext.SaveChanges();
            }
            else
            {
                users = null;
            }
            return users;
        }
        //Delete team from INmemory Db and return teams
        public async Task<bool> UserDeleteAsync(TeamUser user)
        {
            var users = _dbContext.TeamUsers.FirstOrDefault(e => e.LastName == user.LastName);
            if (users != null)
            {
                _dbContext.TeamUsers.Remove(users);
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
