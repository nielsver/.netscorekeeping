using Microsoft.AspNetCore.Mvc;
using webAPI.Models;
using webAPI.Repositories;

namespace webAPI.Controllers
{
    [ApiController]
    [Route("api/teams")]
    public class TeamsController : ControllerBase
    {

        MockRepo _repo = new MockRepo();

        public TeamsController() {
        }

        [HttpGet]
        public ActionResult GetAllTeams() {
            return Ok(_repo.GetAllTeams());
        }
        
        [HttpGet("{id}")]
        public ActionResult GetTeamById(int id) {
            
            return Ok(_repo.GetTeamById(id));
        }

    }
}