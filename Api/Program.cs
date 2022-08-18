using Api.Options;
using DataAccess.Interfaces;
using DataAccess.Models;
using DataAccess.Repositories;
using Domain.Interfaces;
using Domain.Services;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Events;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var services = builder.Services;

services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen(options =>
    {
        options.SwaggerDoc("v1", new OpenApiInfo
        {
            Version = "v1",
            Title = "Slice Mate API",
            Description = "An ASP.NET Core Web API for managing Slice Versions",
            TermsOfService = new Uri("https://example.com/terms"),
            Contact = new OpenApiContact
            {
                Name = "Lucas Wiseby",
                Url = new Uri("https://wiseby.github.io")
            },
            License = new OpenApiLicense
            {
                Name = "MIT License",
                Url = new Uri("https://choosealicense.com/licenses/mit/")
            }
        });
    });

services.Configure<MongoDb>(builder.Configuration.GetSection(MongoDb.Position));
services.AddSingleton<IMongoClient>(s =>
{
    var mongoDbOptions = s.GetRequiredService<IOptions<MongoDb>>().Value;
    var mongoClientSettings = MongoClientSettings.FromConnectionString(mongoDbOptions.ConnectionString);
    var env = s.GetService<IWebHostEnvironment>();

    if (env != null && env.IsDevelopment())
    {
        var logger = s.GetService<ILogger<MongoClient>>();
        mongoClientSettings.ClusterConfigurator = builder =>
        {
            builder.Subscribe<CommandStartedEvent>(e =>
            {
                var json = e.Command.ToJson();
                if (json.Length >= 32 && json.Length < 16384 && logger != null)
                {
                    logger.LogDebug($"MongoDb Command: {Environment.NewLine}{json}");
                }
            });
        };
    }
    return new MongoClient(mongoClientSettings);
});
services.AddSingleton(s =>
{
    var mongoDbOptions = s.GetRequiredService<IOptions<MongoDb>>().Value;
    return s.GetRequiredService<IMongoClient>().GetDatabase(mongoDbOptions.Database);
});
services.AddSingleton(s => s.GetRequiredService<IMongoDatabase>().GetCollection<Slice>("Slices"));
services.AddSingleton(s => s.GetRequiredService<IMongoDatabase>().GetCollection<Model>("Models"));
services.AddSingleton(s => s.GetRequiredService<IMongoDatabase>().GetCollection<Slicing>("Slicings"));


services.AddScoped<DataAccess.Interfaces.ISliceService, SliceRepository>();
services.AddScoped<IModelRepository, ModelRepository>();
services.AddScoped<ISlicingRepository, SlicingRepository>();
services.AddScoped<Domain.Interfaces.ISliceService, SliceService>();
services.AddScoped<IModelService, ModelService>();
services.AddScoped<ISlicingService, SlicingService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
