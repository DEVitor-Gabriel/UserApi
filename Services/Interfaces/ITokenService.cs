// using UserApi.Data.Dto;
using UserApi.Models;

namespace UserApi.Services.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}