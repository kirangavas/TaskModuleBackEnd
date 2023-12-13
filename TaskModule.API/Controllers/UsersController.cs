using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskModule.ApplicationLayer.Services;
using TaskModule.DomainLayer.Response;

namespace TaskModule.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpGet(Name = "GetUsers")]
        public async Task<ActionResult<IEnumerable<TaskUserModelResponse>>> Get()
        {
            var UserList = await _userService.GetAllUserList();

            return Ok(UserList);

        }
    }
}