namespace MediaContent.Api.Repositories.Interfaces;

public interface IMediaContentRepository
{
    Task<Entities.MediaContent?> GetMediaContentByIdAsync(int id);

    Task<IEnumerable<Entities.MediaContent>> GetAllMediaContentAsync();

    Task<int> AddMediaContentAsync(Entities.MediaContent mediaContent);

    Task DeleteMediaContentAsync(Entities.MediaContent mediaContent);
    
    Task SaveChangesAsync();
}