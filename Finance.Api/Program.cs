using Finance.Api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDBContext>(
    x => x.UseSqlite());

var app = builder.Build();


app.MapGet("/", () => "Hello World!");

app.Run();
