using Microsoft.EntityFrameworkCore;
using TessismoWebApi.Infra;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<TessismoDbContext>(options => options.UseInMemoryDatabase("TessismoDb"));
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
