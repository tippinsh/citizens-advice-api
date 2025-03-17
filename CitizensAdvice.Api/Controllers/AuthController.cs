using CitizensAdvice.Api.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CitizensAdvice.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    public IActionResult Register(UserRequestDto request)
    {
        return Ok();
    }

    public IActionResult Login(UserLoginDto request)
    {
        return Ok();
    }
}