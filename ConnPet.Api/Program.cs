using ConnPet.Api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connStr = builder.Configuration.GetConnectionString("DefaultConnection") ?? string.Empty;
builder.Services.AddDbContext<AppDbContext>(x => { x.UseSqlServer(connStr); });


var app = builder.Build();

app.MapGet("/", () => new { Status = "OK" });

app.Run();
