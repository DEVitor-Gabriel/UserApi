using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UserApi.Data.Dto;
using UserApi.Models;
using UserApi.Services.Interfaces;

namespace UserApi.Services
{
    public class UserService : IUserService
    {
        private IMapper _mapper;
        private UserManager<User> _userManager;

        public UserService(IMapper mapper, UserManager<User> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task CreateUserAsync(CreateUserDto dto)
        {
            User user = _mapper.Map<User>(dto);

            IdentityResult result = await _userManager.CreateAsync(user, dto.Password);

            if (!result.Succeeded)
            {
                throw new Exception(result.Errors.First().Description);
            }
        }
    }
}