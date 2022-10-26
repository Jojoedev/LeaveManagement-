using LeaveManagement.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Configuration.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(

                new IdentityRole

                { //ADMIN
                    Id = "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311",
                    Name = Roles.Adminstrator,
                    NormalizedName = Roles.Adminstrator.ToUpper()
                    // bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87300

                },
                new IdentityRole

                {
                    //USER
                    Id = "bf65ce0b-8c04-4c70-a124-78b4dbd87613",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()


                },
                 new IdentityRole

                 {
                     //IT
                     Id = "bf65ce0b-8c04-4c70-a124-78b4dbd87666",
                     Name = Roles.IT,
                     NormalizedName = Roles.IT.ToUpper()

                 }


          ); 
        }
    }
}