using DataAccess.Interfaces;
using DataAccess.Repositories;
using Domain.Interfaces;
using Domain.Services;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
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
builder.Services.AddScoped<DataAccess.Interfaces.ISliceService, SliceRepository>();
builder.Services.AddScoped<IModelRepository, ModelRepository>();
builder.Services.AddScoped<ISlicingRepository, SlicingRepository>();
builder.Services.AddScoped<Domain.Interfaces.ISliceService, SliceService>();
builder.Services.AddScoped<IModelService, ModelService>();
builder.Services.AddScoped<ISlicingService, SlicingService>();

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
