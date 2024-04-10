using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProfileDal.Roles.Models;
using ProfileDal.Users.Models;
namespace ProfileDal.EF
{
    public class UserRoleDbContext : IdentityDbContext
    {

        public DbSet<RoleDal> Roles{ get; set; }
        public DbSet<UserDal> AppUsers{ get; set; }

        public UserRoleDbContext(DbContextOptions<UserRoleDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}