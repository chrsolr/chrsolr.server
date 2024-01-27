global using chrsolr.Data;
global using chrsolr.DTOs;
global using chrsolr.Interfaces;
global using chrsolr.Models;
global using chrsolr.Services;
global using Microsoft.EntityFrameworkCore;

// using Microsoft.AspNetCore.Authentication.JwtBearer;
// using Microsoft.IdentityModel.Tokens;
// using System.Text;

var builder = WebApplication.CreateBuilder(args);
var dotenv = builder.Configuration["DOTENV"] ?? "";

DotEnv.Load(Path.Combine(Directory.GetCurrentDirectory(), dotenv));
builder.Configuration.AddEnvironmentVariables();

var db =
    Environment.GetEnvironmentVariable("DB_CONNECTION_STRING")
    ?? builder.Configuration.GetConnectionString("DB");

builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(db));
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IAboutService, AboutService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
