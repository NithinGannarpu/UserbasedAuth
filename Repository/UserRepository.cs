using UserbasedAuth.Data;
using UserbasedAuth.Models;
using UserbasedAuth.Models.DTOs;

namespace UserbasedAuth.Repository
{
    public class UserRepository
    {
        private readonly Users users;

        public UserRepository(Users _users)
        {
            users = _users;
        }

        public async Task<User> GetUserAsync(int id)
        {
            var user = users.userss.FirstOrDefault(x => x.Id == id);
            return user;
        }

        public async Task<bool> LoginAsync(LoginDTO loginDetails)
        {
            if (loginDetails.Email != null && loginDetails.Password != null)
            {
                var userExists = users.userss.Select(x => x.Email == loginDetails.Email && x.Password == loginDetails.Password).First();
                return userExists;
            }
            return false;
        }

        public async Task<User> GetEmployeeByEmail(string email)
        {
            var user = users.userss.FirstOrDefault(user => user.Email == email);
            return user;
        }
    }
}
