using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs
{
    public record UserForAuthenticationDto
    {
        [Required(ErrorMessage ="Kullanıcı adı girilmesi zorunludur.")]
        public string? UserName { get; init; }
        [Required(ErrorMessage ="Şifre girilmesi zorunludur.")]
        public string? Password { get; init; }

    }
}
