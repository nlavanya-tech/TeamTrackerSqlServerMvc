using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TeamTrackerSqlServerMvc.BusinessLayer.Interface;
using TeamTrackerSqlServerMvc.DataLayer.Model;

namespace TeamTrackerSqlServerMvc.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService teamservice;
        private readonly IUserService _UserService;
        public TeamController(ITeamService teamservice)
        {
            this.teamservice = teamservice;
            // _UserService = userservice;
        }
        public async Task<ActionResult> GetTeamsDetails()
        {
            var list = await teamservice.TeamReadAsync();
            return View(list);
        }
        //[HttpGet]
        //public async Task<IActionResult> CreateTeam()
        //{
        //     var users = await _UserService.GetAllUsersNames();

        //  //  ViewBag.userlist = users;

        //    return View();
        //}
        //[HttpPost]
        public async Task<ActionResult> CreateTeam(Team teams)
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddTeam(Team teams)
        {
            await teamservice.TeamCreateAsync(teams);
            return RedirectToAction("GetTeamsDetails", "Team");
        }
        [HttpGet]
        public async Task<ActionResult> EditTeam()
        {
            return View();
        }
        [HttpPut]
        public async Task<ActionResult> UpdateTeam(Team teams)
        {
            await teamservice.TeamUpdateAsync(teams);
            return RedirectToAction("GetTeamsDetails", "Team");
        }
        [HttpDelete]
        public async Task<ActionResult> DeleteTeam(Team teams)
        {
            await teamservice.TeamDeleteAsync(teams);
            return RedirectToAction("GetTeamsDetails", "Team");
        }
    }
}
