using LeaveManagement.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static LeaveManagement.Areas.Identity.Pages.Account.RegisterModel;

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
                    Name = RolesSeed.Administrator,
                    NormalizedName = RolesSeed.Administrator.ToUpper()

                },
                new IdentityRole

                {
                    //USER
                    Id = "bf65ce0b-8c04-4c70-a124-78b4dbd87613",
                    Name = RolesSeed.User,
                    NormalizedName = RolesSeed.User.ToUpper(),
                   
                },
                 new IdentityRole

                 {
                     //IT
                     Id = "bf65ce0b-8c04-4c70-a124-78b4dbd87666",
                     Name = RolesSeed.IT,
                     NormalizedName = RolesSeed.IT.ToUpper()
                 },

                  new IdentityRole

                  {
                      //Accounts
                      Id = "bf65ce0b-8c04-4c70-a124-78b4dbd87667",
                      Name = RolesSeed.Accounts,
                      NormalizedName = RolesSeed.Accounts.ToUpper()
                  }


          ); 
        }
    }
}