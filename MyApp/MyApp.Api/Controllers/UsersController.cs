using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.Common.Entities;
using MyApp.Data.Interfaces;

namespace MyApp.Api.Controllers
{

    public class UsersController : CommonController
    {
        private readonly IUsersRepository _usersRepo;
        public UsersController(IUsersRepository usersRepo)
        {
            _usersRepo = usersRepo;
        }
        [HttpGet]
        public async Task<ActionResult> GetUsers()
        {
            var users = await _usersRepo.GetUsers();
            if (users == null || users.Count() == 0)
                return NoContent();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetUser(int id)
        {
            var users = await _usersRepo.GetUser(id);
            if (users == null)
                return NoContent();
            return Ok(users);
        }
    }
}
