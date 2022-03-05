using Microsoft.AspNetCore.Identity;
using DeliveryApp.Models;
using System.Threading.Tasks;
using System.Linq;

namespace DeliveryApp.Data
{
    public static class ContextSeed
    {   
        public enum Roles
        {
            SuperAdmin,
            Basic
        }
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Roles.SuperAdmin.ToString()));

        }


        public static async Task SeedSuperAdminAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Default User superadmin
            var defaultUser = new ApplicationUser
            {
                UserName = "superadmin",
                Email = "superadmin@email.com",
                FirstName = "super",
                LastName = "admin",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };
            //Asignament Role to user
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);

                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "Contraseña23!");
                    await userManager.AddToRoleAsync(defaultUser, Roles.SuperAdmin.ToString());
                    
                }

            }
        }
    }
}
