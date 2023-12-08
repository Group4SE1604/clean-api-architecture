
using BuberDinner.Application.Services.Auth;
using BuberDinner.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    [ErrorHandlingFilter]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthenticationController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public IActionResult Register(RegisterRequest request)
        {
            var authResult = _authService.Register(
                request.FirstName,
                request.LastName,
                request.Email,
                request.Password
            );
            var response = new RegisterResponse(
                "Register success",
                authResult.Email,
                authResult.FirstName,
                authResult.LastName
            );
            return Ok(response);
        }
        [HttpPost]
        public IActionResult Login(LoginRequest request)
        {
            var authResult = _authService.Login(
               request.Email, request.Password
            );
            return Ok(authResult);
        }
    }
}