using HomeTask52_Events.Models;
using HomeTask52_Events.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HT_N52.Events.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IUserService _userService;

        public AccountsController(IUserService userSercice)
        {
            _userService = userSercice;
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateUser([FromBody] User user)
        {
            var result = _userService.CreateAsync(user);
            return Ok(result);
        }
    }
}
