using ProfileDal;
using ProfileLogic;
using ProfileLogic.Users.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();

builder.Services.TryAddLogic();
builder.Services.TryAddDal();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();