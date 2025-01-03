using MediaContent.Api.DTOs;
using MediaContent.Api.Exceptions;
using MediaContent.Api.Mappers;
using MediaContent.Api.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MediaContent.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MediaContentController(IMediaContentRepository mediaContentRepository, ILogger<MediaContentController> logger, IUsersRepository usersRepository) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateMediaContent([FromBody] MediaContentAddRequest addRequest)
    {
        logger.LogInformation("Adding media-content {@addRequest}", addRequest);

        var user = await usersRepository.GetUserByIdAsync(addRequest.UserId);
        
        if(user == null)
            throw new NotFoundException(nameof(User), addRequest.UserId.ToString());

        var mappedContent = addRequest.ToModel();

        var id = await mediaContentRepository.AddMediaContentAsync(mappedContent);
        
        return CreatedAtAction(nameof(GetMediaContentById), new { id }, new { id });
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetMediaContentById([FromRoute] int id)
    {
        logger.LogInformation("Getting content with id {id}", id);
        
        var content = await mediaContentRepository.GetMediaContentByIdAsync(id);

        if (content == null)
            throw new NotFoundException(nameof(Entities.MediaContent), id.ToString());

        var mappedContent = content.ToDto();

        return Ok(mappedContent);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetContents()
    {
        logger.LogInformation("Getting all content from database");

        var content = await mediaContentRepository.GetAllMediaContentAsync();

        var mappedContent = content.Select(z => z.ToDto());

        return Ok(mappedContent);
    }
    
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> RemoveContent([FromRoute] int id)
    {
        logger.LogInformation("Deleting content with id: {id}", id);

        var content = await mediaContentRepository.GetMediaContentByIdAsync(id);
        
        if(content == null)
            throw new NotFoundException(nameof(Entities.MediaContent), id.ToString());

        await mediaContentRepository.DeleteMediaContentAsync(content);

        return NoContent();
    }
    
    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateMediaContent([FromBody] MediaContentAddRequest updateRequest, [FromRoute] int id)
    {
        var content = await mediaContentRepository.GetMediaContentByIdAsync(id);
        
        if(content == null)
            throw new NotFoundException(nameof(Entities.MediaContent), id.ToString());

        var mappedContentRequest = updateRequest.ToModel();

        content.Title = mappedContentRequest.Title;
        content.Body = mappedContentRequest.Body;
        content.ContentType = mappedContentRequest.ContentType;
        content.CreatedAt = mappedContentRequest.CreatedAt;
        
        await mediaContentRepository.SaveChangesAsync();

        return NoContent();
    }
}