using MediaContent.Api.Entities;
using MediaContent.Api.Infrastructure;
using MediaContent.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MediaContent.Api.Repositories;

public class UsersRepository(ApplicationDbContext context) : IUsersRepository
{
    public async Task<User?> GetUserByIdAsync(int id)
    {
        return await context.Users.Include(z=>z.MediaContents).FirstOrDefaultAsync(z=>z.Id == id);
    }

    public async Task<IEnumerable<User>> GetAllUsersAsync()
    {
        return await context.Users.Include(z=>z.MediaContents).ToListAsync();
    }

    public async Task<int> AddUserAsync(User user)
    {
        await context.Users.AddAsync(user);

        await context.SaveChangesAsync();

        return user.Id;
    }

    public async Task DeleteUserAsync(User user)
    {
        context.Users.Remove(user);

        await context.SaveChangesAsync();
    }

    public async Task SaveChangesAsync()
    {
        await context.SaveChangesAsync();
    }
}