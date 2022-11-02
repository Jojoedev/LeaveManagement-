using LeaveManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace LeaveManagement.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
                
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();

            builder.HasData

                (

                        new Employee
                        {
                          
                            Id = "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340",
                            Email = "doc@yahoo.com",
                            NormalizedEmail = "DOCS@YAHOO.COM",
                            NormalizedUserName = "DOC@YAHOO.COM",
                            UserName = "doc@yahoo.com",
                            FirstName = "DON",
                            LastName = "DOC",
                            PasswordHash = hasher.HashPassword(null, "Password1"),
                            EmailConfirmed = true

                        },
                        new Employee
                        { 
                            

                            Id = "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230",
                            Email = "Jojoe@yahoo.com",
                            NormalizedEmail = "JOJOE@YAHOO.COM",
                            NormalizedUserName = "JOJOE@YAHOO.COM",
                            UserName = "jojoe@YAHOO.COM",
                            FirstName = "JOE",
                            LastName = "JO",
                            PasswordHash = hasher.HashPassword(null, "Password1"),
                            EmailConfirmed = true
                        },
                        
                        new Employee
                        { 

                            Id = "93fd5a9f - 677a - 4998 - a010 - 16b997082282",
                            Email = "yus@yahoo.com",
                            NormalizedEmail = "YUS@YAHOO.COM",
                            NormalizedUserName = "YUS@YAHOO.COM",
                            UserName = "yus@YAHOO.COM",

                            FirstName = "BABATUNDE",
                            LastName = "Yusuf",
                            PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                            EmailConfirmed = true
                        },
                        new Employee
                        {

                            Id = "93fd5a9f - 677a - 4998 - a010 - 16b997082241",
                            Email = "accts@yahoo.com",
                            NormalizedEmail = "ACCTS@YAHOO.COM",
                            NormalizedUserName = "ACCTS@YAHOO.COM",
                            UserName = "ACCTS@YAHOO.COM",

                            FirstName = "Friday",
                            LastName = "Onuh",
                            PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                            EmailConfirmed = true
                        }



                );
        }
    }
}