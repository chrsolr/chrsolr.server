global using chrsolr_api.Models;
global using chrsolr_api.Services;
global using chrsolr_api.DTOs;
global using Microsoft.EntityFrameworkCore;
global using chrsolr_api.Data;
global using chrsolr_api.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

DotEnv.Load(Path.Combine(Directory.GetCurrentDirectory(), ".env"));
config.AddEnvironmentVariables();

builder.Services.AddDbContext<DataContext>(
    // options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
    options => options.UseSqlServer(Environment.GetEnvironmentVariable("DB_CONNECTION_STRING"))
);

// Auth
builder.Services
    .AddAuthentication(x =>
    {
        x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(x =>
    {
        x.TokenValidationParameters = new TokenValidationParameters
        {
            ValidIssuer = config["JWT:Issuer"],
            ValidAudience = config["JWT:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JWT:KEY"]!)),
            ValidateIssuer = true,
            ValidateActor = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true
        };
    });

builder.Services.AddAuthorization();
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Services/Repository
builder.Services
    .AddScoped<IAuthService, AuthService>()
    .AddScoped<IAboutService, AboutService>()
    .AddScoped<IBlogPostService, BlogPostService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
bool.TryParse(Environment.GetEnvironmentVariable("SHOW_SWAGGER"), out bool showSwaggerEndpoints);

if (showSwaggerEndpoints == true)
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
