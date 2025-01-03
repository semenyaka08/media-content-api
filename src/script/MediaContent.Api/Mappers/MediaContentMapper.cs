using MediaContent.Api.DTOs;

namespace MediaContent.Api.Mappers;

public static class MediaContentMapper
{
    public static MediaContentGetResponse ToDto(this Entities.MediaContent mediaContent)
    {
        return new MediaContentGetResponse
        {
            Id = mediaContent.Id,
            Title = mediaContent.Title,
            Body = mediaContent.Body,
            ContentType = mediaContent.ContentType,
            DateTime = mediaContent.CreatedAt,
            UserId = mediaContent.UserId
        };
    }
    
    public static Entities.MediaContent ToModel(this MediaContentAddRequest addRequest)
    {
        return new Entities.MediaContent
        {
            Title = addRequest.Title,
            Body = addRequest.Body,
            ContentType = addRequest.ContentType,
            CreatedAt = DateTime.Now,
            UserId = addRequest.UserId
        };
    }
}