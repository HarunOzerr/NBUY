using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OzelDersler.Entity.Concrete;
using OzelDersler.Entity.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersler.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            List<User> users = new List<User>
            {
                new User
                {
                    Id = "student",
                    Email = "harun@gmail.com",
                    UserName = "student",
                    NormalizedUserName = "STUDENT"
                },
                new User
                {
                    Id = "teacher",
                    Email = "mert@gmail.com",
                    UserName = "teacher",
                    NormalizedUserName = "TEACHER"
                }
            };
            modelBuilder.Entity<User>().HasData(users);

            List<Role> roles = new List<Role>
            {
                new Role
                {
                    Name = "Teacher",
                    Description = "Teacher Rolü",
                    NormalizedName = "TEACHER"
                },
                new Role
                {
                    Name = "Student",
                    Description = "Student Rolü",
                    NormalizedName = "STUDENT"
                }
            };
            modelBuilder.Entity<Role>().HasData(roles);


            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    UserId=users[0].Id,
                    RoleId=roles.First(r=>r.Name=="Student").Id
                },
                new IdentityUserRole<string>
                {
                    UserId=users[1].Id,
                    RoleId=roles.First(r=>r.Name=="Teacher").Id
                }
            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }
    }
}
