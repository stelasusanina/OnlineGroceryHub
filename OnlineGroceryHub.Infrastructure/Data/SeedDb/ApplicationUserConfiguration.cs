using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineGroceryHub.Infrastructure.SeedDb;
using OnlineGroceryHub.Models;

namespace OnlineGroceryHub.Infrastructure.Data.SeedDb
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var data = new SeedData();

            builder.HasData(new ApplicationUser[]
            {
                data.Admin,
                data.User
            });
        }
    }
}
