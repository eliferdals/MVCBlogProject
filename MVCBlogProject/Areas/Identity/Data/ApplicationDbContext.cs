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
        string visitorRoleId = Guid.NewGuid().ToString();

        IdentityRole writerRole = new IdentityRole { Id = writerRoleId, Name = "Writer", NormalizedName = "WRITER" };
        IdentityRole visitorRole = new IdentityRole { Id = visitorRoleId, Name = "Visitor", NormalizedName = "VISITOR" };

        builder.Entity<IdentityRole>().HasData(writerRole);
       builder.Entity<IdentityRole>().HasData(visitorRole);

        string writerAppUserId = Guid.NewGuid().ToString();
        string visitorAppUserId = Guid.NewGuid().ToString();

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

        ApplicationUser visitorUser = new ApplicationUser
        {
            Id = visitorAppUserId,
            FirstName = "Visitor",
            LastName = "Visitor",
            Email = "visitor@visitor.com",
            NormalizedEmail = "VISITOR@VISITOR.COM",
            UserName = "visitor@visitor.com",
            NormalizedUserName = "VISITOR@VISITOR.COM",
            EmailConfirmed = true
        };

        visitorUser.PasswordHash = hasher.HashPassword(visitorUser, "Visitor123!");

        builder.Entity<ApplicationUser>().HasData(writerUser);
        builder.Entity<ApplicationUser>().HasData(visitorUser);

        IdentityUserRole<string> writerUserRole = new IdentityUserRole<string> { RoleId = writerRoleId, UserId = writerAppUserId };
        IdentityUserRole<string> visitorUserRole = new IdentityUserRole<string> { RoleId = visitorRoleId, UserId = visitorAppUserId };

        builder.Entity<IdentityUserRole<string>>().HasData(writerUserRole);
        builder.Entity<IdentityUserRole<string>>().HasData(visitorUserRole);

        builder.Entity<IdentityUserClaim<string>>().HasData(new IdentityUserClaim<string>
        {
            UserId = writerAppUserId,
            Id = 1,
            ClaimType = "IsWriter",
            ClaimValue = "true"
        });
    }
}
