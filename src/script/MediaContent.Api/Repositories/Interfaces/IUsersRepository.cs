using MediaContent.Api.Entities;

namespace MediaContent.Api.Repositories.Interfaces;

public interface IUsersRepository
{
    Task<User?> GetUserByIdAsync(int id);

    Task<IEnumerable<User>> GetAllUsersAsync();

    Task<int> AddUserAsync(User user);

    Task DeleteUserAsync(User user);
    
    Task SaveChangesAsync();
}