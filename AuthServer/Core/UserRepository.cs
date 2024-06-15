using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AuthServer.Core
{
    public class UserRepository : IUserService
    {
        // Implement methods to interact with persistence mechanism (e.g., database)

        public Task<User> GetUserByUsernameAsync(string username)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task CreateUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserAsync(string username)
        {
            throw new NotImplementedException();
        }
    }
}
