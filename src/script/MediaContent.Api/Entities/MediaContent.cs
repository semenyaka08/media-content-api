namespace MediaContent.Api.Entities;

public class MediaContent
{
    public int Id { get; set; }

    public required string Title { get; set; }

    public required string Body { get; set; }

    public required string ContentType { get; set; }

    public DateTime CreatedAt { get; set; }

    public int UserId { get; set; }

    public User User { get; set; } = null!;
}