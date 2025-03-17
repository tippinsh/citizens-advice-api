using CitizensAdvice.Api.Models;

namespace CitizensAdvice.Api.Dtos;

public class UserRequestDto
{
    public string Email { get; set; }
    public string Password { get; set; }
    public RoleType Role { get; set; }
}