using Microsoft.AspNetCore.Identity;

namespace UserApi.Models
{
    public class User : IdentityUser
    {
        public DateTime DataNascimento { get; set; }
        public User() : base() { }

    }
}