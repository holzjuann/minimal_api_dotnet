using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using minimal_api.src.Domain.DTOs;
using minimal_api.src.Domain.Interfaces;
using minimal_api.src.Domain.Services;
using minimal_api.src.Infrastructure.DB;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IAdmService, AdmService>();

builder.Services.AddDbContext<Context>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionDb"));
});


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", ([FromBody]LoginDTO loginDTO, IAdmService admService) => {
    if (admService.Login(loginDTO) != null)
    {
        return Results.Ok("Login Aprovado!");
    } else
    {
        return Results.Unauthorized();
    }
});

app.Run();
