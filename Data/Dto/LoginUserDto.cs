using System.ComponentModel.DataAnnotations;

namespace UserApi.Data.Dto
{
    public class LoginUserDto
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}