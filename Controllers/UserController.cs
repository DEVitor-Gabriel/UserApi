
using Microsoft.AspNetCore.Mvc;
using UserApi.Data.Dto;
using UserApi.Services.Interfaces;

namespace UserApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserDto dto)
        {
            await _userService.CreateUserAsync(dto);

            return Ok("User created successfully");
        }
    }
}