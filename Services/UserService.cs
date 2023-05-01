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
        private SignInManager<User> _signInManager;
        private ITokenService _tokenService;

        public UserService(IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, ITokenService tokenService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
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

        public async Task<string> LoginAsync(LoginUserDto dto)
        {
            SignInResult result = await _signInManager.PasswordSignInAsync(dto.Username, dto.Password, false, false);

            if (!result.Succeeded)
            {
                throw new Exception("Login failed");
            }

            User user = await _userManager.FindByNameAsync(dto.Username);

            string token = _tokenService.CreateToken(user);

            return token;
            
        }
    }
}