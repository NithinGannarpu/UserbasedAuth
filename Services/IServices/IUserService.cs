using UserbasedAuth.Models;
using UserbasedAuth.Models.DTOs;

namespace UserbasedAuth.Services.IServices
{
    public interface IUserService
    {
        public Task<LoginResponseDTO> Login(LoginDTO loginDTO);
        public Task<User> GetUser(int id);
    }
}
