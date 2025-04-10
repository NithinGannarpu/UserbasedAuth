using UserbasedAuth.Models;
using UserbasedAuth.Models.DTOs;
using UserbasedAuth.Repository;
using UserbasedAuth.Services.IServices;

namespace UserbasedAuth.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository _userRepository;
        private readonly ITokenGenerator _tokenGenerator;
        public UserService(UserRepository userRepository, ITokenGenerator tokenGenerator) 
        {
            _userRepository = userRepository;
            _tokenGenerator = tokenGenerator;
        }
        public Task<User> GetUser(int id)
        {
            var user = _userRepository.GetUserAsync(id);
            return user;
        }


        public async Task<LoginResponseDTO> Login(LoginDTO loginDTO)
        {
            bool loginSuccess = await _userRepository.LoginAsync(loginDTO);
            LoginResponseDTO loginResponseDTO = new LoginResponseDTO();
            if (loginSuccess)
            {
                User user = await _userRepository.GetEmployeeByEmail(loginDTO.Email);
                loginResponseDTO.Token = _tokenGenerator.GenerateToken(user, user.Role);
                loginResponseDTO.User = user;
                loginResponseDTO.isSuccess = true;
            }
            else
            {
                loginResponseDTO.isSuccess= false;
                loginResponseDTO.message = "Login failed...";
                loginResponseDTO.Token = null;
                loginResponseDTO.User = null;
            }
            return loginResponseDTO;
        }
    }
}
