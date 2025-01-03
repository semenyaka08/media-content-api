namespace MediaContent.Api.DTOs;

public class MediaContentGetResponse
{
    public int Id { get; set; }

    public required string Title { get; set; }

    public required string Body { get; set; }

    public required string ContentType { get; set; }
    
    public DateTime DateTime { get; set; }

    public int UserId { get; set; }
}