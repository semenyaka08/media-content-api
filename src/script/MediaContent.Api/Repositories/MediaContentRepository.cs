using MediaContent.Api.Infrastructure;
using MediaContent.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MediaContent.Api.Repositories;

public class MediaContentRepository(ApplicationDbContext context) : IMediaContentRepository
{
    public async Task<Entities.MediaContent?> GetMediaContentByIdAsync(int id)
    {
        return await context.MediaContents.FirstOrDefaultAsync(z=>z.Id == id);
    }

    public async Task<IEnumerable<Entities.MediaContent>> GetAllMediaContentAsync()
    {
        return await context.MediaContents.ToListAsync();
    }

    public async Task<int> AddMediaContentAsync(Entities.MediaContent mediaContent)
    {
        await context.MediaContents.AddAsync(mediaContent);

        await context.SaveChangesAsync();

        return mediaContent.Id;
    }

    public async Task DeleteMediaContentAsync(Entities.MediaContent mediaContent)
    {
        context.MediaContents.Remove(mediaContent);

        await context.SaveChangesAsync();
    }

    public async Task SaveChangesAsync()
    {
        await context.SaveChangesAsync();
    }
}