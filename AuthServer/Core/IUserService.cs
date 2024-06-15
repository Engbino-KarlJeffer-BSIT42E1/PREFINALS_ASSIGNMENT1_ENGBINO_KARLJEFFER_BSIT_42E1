using System.Collections.Generic;
using System.Threading.Tasks;

namespace AuthServer.Core
{
    public interface IUserService
    {
        Task<User> GetUserByUsernameAsync(string username);
        Task<List<User>> GetAllUsersAsync();
        Task CreateUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(string username);
    }
}
