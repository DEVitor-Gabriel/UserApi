
using Microsoft.AspNetCore.Mvc;
using UserApi.Data.Dto;

namespace UserApi.Controllers
{
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateUser(CreateUserDto dto)
        {
            throw new NotImplementedException();
        }
    }
}