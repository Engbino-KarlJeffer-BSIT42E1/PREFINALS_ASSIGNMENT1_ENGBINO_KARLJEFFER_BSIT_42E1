using System.Threading.Tasks;
using AuthServer.Core;
using Microsoft.AspNetCore.Mvc;

namespace AuthServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid request data.");
            }

            var isValid = await _authService.ValidateCredentialsAsync(model.Username, model.Password);
            if (!isValid)
            {
                return Unauthorized("Invalid username or password.");
            }

            var token = await _authService.GenerateJwtTokenAsync(model.Username);
            return Ok(new { Token = token });
        }
    }

    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}