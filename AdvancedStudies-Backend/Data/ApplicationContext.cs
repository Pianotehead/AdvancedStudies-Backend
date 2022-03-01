using AdvancedStudies_Backend.Models.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AdvancedStudies_Backend.Data
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole { Name = "Student", NormalizedName = "STUDENT" },
                    new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                    new IdentityRole { Name = "Teacher", NormalizedName = "TEACHER" }
                );

        }
    }
}
