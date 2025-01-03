namespace MediaContent.Api.DTOs;

public class UserGetResponse
{
    public int Id { get; set; }

    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public required string Email { get; set; }

    public IEnumerable<MediaContentGetResponse> MediaContents { get; set; } = [];
}