using ProfileDal;
using ProfileDal.EF;
using ProfileLogic;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<UserRoleDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSingleton<ObjectPool<IConnection>>(serviceProvider =>
{
    return new DefaultObjectPool<IConnection>(new RabbitConnectionPool("localhost"), Environment.ProcessorCount * 2);
});
builder.Services.TryAddLogic();
builder.Services.TryAddDal();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();