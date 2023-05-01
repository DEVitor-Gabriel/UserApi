
using Microsoft.AspNetCore.Mvc;
using UserApi.Data.Dto;

namespace UserApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateUser(CreateUserDto dto)
        {
            throw new NotImplementedException();
        }
    }
}