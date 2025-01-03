using MediaContent.Api.Infrastructure;
using MediaContent.Api.Middlewares;
using MediaContent.Api.Repositories;
using MediaContent.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace MediaContent.Api.Extesions;

public static class ServiceCollectionExtensions
{
    public static void AddPresentation(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();

        builder.Services.AddScoped<ExceptionHandlingMiddleware>();

        builder.Host.UseSerilog((context, configuration) =>
        {
            configuration.ReadFrom.Configuration(context.Configuration);
        });

        builder.Services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
                .EnableSensitiveDataLogging();
        });
        
        builder.Services.AddScoped<IUsersRepository, UsersRepository>();
        builder.Services.AddScoped<IMediaContentRepository, MediaContentRepository>();
    }
}