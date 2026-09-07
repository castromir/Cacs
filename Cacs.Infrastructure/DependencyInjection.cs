using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cacs.Application.Repositories;
using Cacs.Infrastructure.Persistence.MongoDB;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MongoDB.Driver;

namespace Cacs.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration,
        IHostEnvironment environment)
    {
        var mongoSettings = configuration
       .GetSection("MongoDbSettings")
       .Get<MongoDbSettings>();

        var mongoClient = new MongoClient(
            mongoSettings!.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            mongoSettings.DatabaseName);

        services.AddSingleton<IMongoClient>(mongoClient);

        services.AddSingleton<IMongoDatabase>(mongoDatabase);

        services.AddScoped<IPlayerRepository, MongoPlayerRepository>();

        services.AddSignalR(options =>
        {
            if (environment.IsDevelopment())
            {
                options.EnableDetailedErrors = true;
            }
        })
        .AddJsonProtocol(options =>
        {
            options.PayloadSerializerOptions.PropertyNamingPolicy =
                JsonNamingPolicy.CamelCase;

            options.PayloadSerializerOptions.DictionaryKeyPolicy =
                JsonNamingPolicy.CamelCase;

            options.PayloadSerializerOptions.Converters.Add(
                new JsonStringEnumConverter());
        });

        services.AddResponseCompression(options =>
        {
            options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
                ["application/octet-stream"]);
        });

        return services;
    }

    public static WebApplication UseInfrastructure(
        this WebApplication app)
    {
        app.UseResponseCompression();

        return app;
    }
}
