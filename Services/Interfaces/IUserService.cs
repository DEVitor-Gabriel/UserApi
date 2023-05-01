using UserApi.Data.Dto;

namespace UserApi.Services.Interfaces
{
    public interface IUserService
    {
        Task CreateUserAsync(CreateUserDto dto);
        Task LoginAsync(LoginUserDto dto);
    }
}
