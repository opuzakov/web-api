using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapPost("/sample", ([FromBody(EmptyBodyBehavior = EmptyBodyBehavior.Allow)] int? data) =>
{
    return Results.Ok();
});

app.Run();
