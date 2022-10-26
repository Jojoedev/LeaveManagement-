using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Configuration.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData
                (
                new IdentityUserRole<string>
                {
                    //Admin
                    RoleId = "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311",
                    UserId = "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340"
                },

                new IdentityUserRole<string>
                {
                    RoleId = "bf65ce0b-8c04-4c70-a124-78b4dbd87613",
                    UserId = "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "bf65ce0b-8c04-4c70-a124-78b4dbd87666",
                    UserId = "93fd5a9f - 677a - 4998 - a010 - 16b997082282"
                }

                );
        }

    }
}