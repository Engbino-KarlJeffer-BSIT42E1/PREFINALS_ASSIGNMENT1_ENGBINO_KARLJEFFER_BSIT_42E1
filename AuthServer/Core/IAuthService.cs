using System.Threading.Tasks;

namespace AuthServer.Core
{
    public interface IAuthService
    {
        Task<string> GenerateJwtTokenAsync(string username);
        Task<bool> ValidateCredentialsAsync(string username, string password);
    }
}
