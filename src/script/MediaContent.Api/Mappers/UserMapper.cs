using System.Security.Cryptography;
using System.Text;
using MediaContent.Api.DTOs;
using MediaContent.Api.Entities;

namespace MediaContent.Api.Mappers;

public static class UserMapper
{
    public static User ToUser(this UserAddRequest addRequest)
    {
        return new User
        {
            FirstName = addRequest.FirstName,
            LastName = addRequest.LastName,
            Email = addRequest.Email,
            HashedPassword = HashPassword(addRequest.Password)
        };
    }

    public static UserGetResponse ToDto(this User user)
    {
        return new UserGetResponse
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            MediaContents = user.MediaContents.Select(z=>z.ToDto())
        };
    }
    
    private static string HashPassword(string password)
    {
        using var sha256 = SHA256.Create();
        var bytes = Encoding.UTF8.GetBytes(password);
        var hash = sha256.ComputeHash(bytes);
        return Convert.ToBase64String(hash);
    }
}