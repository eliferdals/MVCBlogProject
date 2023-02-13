using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCBlogProject.Areas.Identity.Data;

namespace MVCBlogProject.Areas.Identity.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());

        string writerRoleId = Guid.NewGuid().ToString();
       // string visitorRoleId = Guid.NewGuid().ToString();

        IdentityRole adminRole = new IdentityRole { Id = writerRoleId, Name = "Writer", NormalizedName = "WRITER" };
        //IdentityRole standardRole = new IdentityRole { Id = visitorRoleId, Name = "Visitor", NormalizedName = "VISITOR" };

        builder.Entity<IdentityRole>().HasData(writerRoleId);
       // builder.Entity<IdentityRole>().HasData(visitorRoleId);

        string writerAppUserId = Guid.NewGuid().ToString();
       // string visitorAppUserId = Guid.NewGuid().ToString();

        var hasher = new PasswordHasher<IdentityUser>();

        ApplicationUser writerUser = new ApplicationUser
        {
            Id = writerAppUserId,
            FirstName = "Writer",
            LastName = "Writer",
            Email = "writer@writer.com",
            NormalizedEmail = "WRITER@WRITER.COM",
            UserName = "writer@writer.com",
            NormalizedUserName = "WRITER@WRITER.COM",
            EmailConfirmed = true
        };

        writerUser.PasswordHash = hasher.HashPassword(writerUser, "Writer123!");

        //ApplicationUser standardUser = new ApplicationUser
        //{
        //    Id = standardAppUserId,
        //    FirstName = "Standard",
        //    LastName = "Standard",
        //    Email = "standard@standard.com",
        //    NormalizedEmail = "STANDARD@STANDARD.COM",
        //    UserName = "standard@standard.com",
        //    NormalizedUserName = "STANDARD@STANDARD.COM",
        //    EmailConfirmed = true
        //};

        //standardUser.PasswordHash = hasher.HashPassword(standardUser, "Standard123!");

        builder.Entity<ApplicationUser>().HasData(writerUser);
        //builder.Entity<ApplicationUser>().HasData(standardUser);
    }
}
