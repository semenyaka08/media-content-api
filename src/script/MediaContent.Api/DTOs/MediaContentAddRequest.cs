namespace MediaContent.Api.DTOs;

public class MediaContentAddRequest
{
    public required string Title { get; set; }

    public required string Body { get; set; }

    public required string ContentType { get; set; }

    public int UserId { get; set; }
}