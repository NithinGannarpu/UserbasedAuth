using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserbasedAuth.Models.DTOs;
using UserbasedAuth.Services.IServices;

namespace UserbasedAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public async Task<LoginResponseDTO> Login([FromBody]LoginDTO loginDetails)
        {
            var login = await _userService.Login(loginDetails);
            return login;
        }
    }
}
