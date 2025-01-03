﻿namespace MediaContent.Api.Entities;

public class User
{
    public int Id { get; set; }
    
    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public required string Email { get; set; }

    public required string HashedPassword { get; set; }

    public ICollection<MediaContent> MediaContents { get; set; } = [];
}