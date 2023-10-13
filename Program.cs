global using chrsolr_api.Models;
global using chrsolr_api.Services;
global using chrsolr_api.DTOs;
global using Microsoft.EntityFrameworkCore;
global using chrsolr_api.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// other
builder.Services.AddScoped<IAboutService, AboutService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Urls.Add("http://0.0.0.0:8080");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
