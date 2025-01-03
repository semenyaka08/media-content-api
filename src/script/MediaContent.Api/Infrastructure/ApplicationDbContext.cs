using MediaContent.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace MediaContent.Api.Infrastructure;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }

    public DbSet<Entities.MediaContent> MediaContents { get; set; }
}