using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCoreIdentity
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
           /* builder.Seed()*/;
            //builder.Entity<IdentityUser>().ToTable("User");

            //builder.Entity<IdentityRole>().ToTable("Role");
            //builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaim");
            //builder.Entity<IdentityRole<string>>().ToTable("UserRole");
            //builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogin");
            //builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaim");
            //builder.Entity<IdentityUserToken<string>>().ToTable("UserToken");
        }
        public DbSet<Category> Categories { get; set; }
    }
}
