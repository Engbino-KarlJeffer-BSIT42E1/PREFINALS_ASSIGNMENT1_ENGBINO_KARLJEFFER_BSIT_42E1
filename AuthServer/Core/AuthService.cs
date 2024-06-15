using System;
using System.Threading.Tasks;

namespace AuthServer.Core
{
    public class AuthService : IAuthService
    {
        private readonly IUserService _userService;

        public AuthService(IUserService userService)
        {
            _userService = userService;
        }

        public Task<string> GenerateJwtTokenAsync(string username)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidateCredentialsAsync(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
