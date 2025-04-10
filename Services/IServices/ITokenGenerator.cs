using UserbasedAuth.Models;

namespace UserbasedAuth.Services.IServices
{
    public interface ITokenGenerator
    {
        string GenerateToken(User user, string role);

    }
}
