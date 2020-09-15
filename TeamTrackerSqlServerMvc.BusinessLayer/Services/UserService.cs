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
   public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        //Get all Usernames 
        public async Task<IEnumerable<TeamUser>> GetAllUserName()
        {
            var users = await _repository.GetAllUserName();

            return users;
        }
        //Get =user and retrun list of users
        public async Task<IEnumerable<TeamUser>> UserReadAsync()
        {
            var users = await _repository.UserReadAsync();
            return users;
        }
        //Create teams
        public async Task<TeamUser> UserCreateAsync(TeamUser user)
        {
            await _repository.UserCreateAsync(user);
            return user;
        }
        //Update teams
        public async Task<TeamUser> UserUpdateAsync(TeamUser user)
        {
            var users = await _repository.UserUpdateAsync(user);

            return users;
        }
        //Delete teams 
        public async Task<bool> UserDeleteAsync(TeamUser user)
        {
            var result = await _repository.UserDeleteAsync(user);
            return result;
        }
    }
}
