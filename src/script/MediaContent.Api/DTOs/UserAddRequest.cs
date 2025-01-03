using System.ComponentModel.DataAnnotations;

namespace MediaContent.Api.DTOs;

public class UserAddRequest
{
    [Required] public string FirstName { get; set; } = string.Empty;

    [Required] public string LastName { get; set; } = string.Empty;

    [EmailAddress]
    [Required] 
    public string Email { get; set; } = string.Empty;

    [Required] public string Password { get; set; } = string.Empty;
}