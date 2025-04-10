using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserbasedAuth.Models;
using UserbasedAuth.Models.DTOs;
using UserbasedAuth.Services.IServices;

namespace UserbasedAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<LoginResponseDTO> Login([FromBody] LoginDTO loginDetails)
        {
            var login = await _userService.Login(loginDetails);
            return login;
        }

        [HttpGet("user/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<User> GetUserAsync([FromRoute] int id)
        {
            var user = await _userService.GetUser(id);
            return user;
        }
    }
}
