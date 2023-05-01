
using System.ComponentModel.DataAnnotations;

namespace UserApi.Data.Dto
{
    public class CreateUserDto
    {
        [Required]
        public string? Username { get; set; }
        
        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "As senhas não conferem")]
        public string? ConfirmPassword { get; set; }
    }
}