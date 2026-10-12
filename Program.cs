using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.MapOpenApi();
  app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.MapGet("/token", () =>
{

}).WithName("Token Endpoint");

app.MapGet("/authorize", () =>
{

}).WithName("Authorization Request");

app.Run();
