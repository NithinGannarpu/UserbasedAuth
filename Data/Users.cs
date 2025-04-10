using UserbasedAuth.Models;

namespace UserbasedAuth.Data
{
    public class Users
    {
        public List<User> userss = new List<User>
        {
            new User
            {
                Name = "Test2",
                Email = "Test@mail.com",
                Username = "Testy101",
                Password = "Test@1234!!",
                Id = 1,
            },
            new User
            {
                Name = "Test",
                Email = "Testy@mail.com",
                Username = "Testyy101",
                Password = "Test@11234!!",
                Id = 2,
                Role = "Admin"
            }
        };
    }
}
