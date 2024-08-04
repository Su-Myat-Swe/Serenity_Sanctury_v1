using Microsoft.AspNetCore.Identity;
using Serenity_Sanctury_v1.Data.Enum;
using Serenity_Sanctury_v1.Models;
using System.Net;

namespace Serenity_Sanctury_v1.Models
{
    public class ConfigureIdentity
    {
        //public static async Task CreateAdminUserAsync(IServiceProvider serviceProvider)
        //{
        //    // Create a scope for resolving services
        //    using (var serviceScope = serviceProvider.CreateScope())
        //    {
        //        // Roles
        //        var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        //        string roleName = "Admin";

        //        // Check if the role exists, if not create it
        //        if (await roleManager.FindByNameAsync(roleName) == null)
        //        {
        //            await roleManager.CreateAsync(new IdentityRole(roleName));
        //        }

        //        // Users
        //        var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<User>>();
        //        string username = "teddysmithdev";
        //        string password = "Coding@1234?";
        //        string adminUserEmail = "teddysmithdeveloper@gmail.com";

        //        // Create admin user if it does not exist
        //        if (await userManager.FindByEmailAsync(adminUserEmail) == null)
        //        {
        //            var newAdminUser = new User
        //            {
        //                UserName = username,
        //                Email = adminUserEmail,
        //                EmailConfirmed = true
        //            };
        //            var result = await userManager.CreateAsync(newAdminUser, password);
        //            if (result.Succeeded)
        //            {
        //                await userManager.AddToRoleAsync(newAdminUser, roleName);
        //            }
        //        }

        //        // Create app user if it does not exist
        //        string appUserEmail = "user@etickets.com";
        //        if (await userManager.FindByEmailAsync(appUserEmail) == null)
        //        {
        //            var newAppUser = new User
        //            {
        //                UserName = "app-user",
        //                Email = appUserEmail,
        //                EmailConfirmed = true,
        //                Address = "221 Ring Road, Callaghan, NSW, 2308, Australia"
        //            };
        //            await userManager.CreateAsync(newAppUser, password);
        //            await userManager.AddToRoleAsync(newAppUser, "User");
        //        }
        //    }
        //public static async Task CreateAdminUserAsync(IApplicationBuilder applicationBuilder)
        //{
        //    using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        //    {
        //        //Roles
        //        var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

        //        // if role doesn't exist, create it
        //        if (await roleManager.FindByNameAsync(roleName) == null)
        //        {
        //            await roleManager.CreateAsync(new IdentityRole(roleName));
        //        }

        //        //Users
        //        var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<User>>();
        //        string adminUserEmail = "teddysmithdeveloper@gmail.com";
        //        // if username doesn't exist, create it and add to role
        //        if (await userManager.FindByNameAsync(username) == null)
        //        {
        //            User user = new User { UserName = username };
        //            var result = await userManager.CreateAsync(user, password);
        //            if (result.Succeeded)
        //            {
        //                await userManager.AddToRoleAsync(user, roleName);
        //            }
        //        }
        //        var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
        //        if (adminUser == null)
        //        {
        //            var newAdminUser = new User()
        //            {
        //                UserName = "teddysmithdev",
        //                Email = adminUserEmail,
        //                EmailConfirmed = true,
        //                Address = null
        //            };
        //            await userManager.CreateAsync(newAdminUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
        //        }

        //        string appUserEmail = "user@etickets.com";

        //        var AppUser = await userManager.FindByEmailAsync(appUserEmail);
        //        if (appUser == null)
        //        {
        //            var newAppUser = new AppUser()
        //            {
        //                UserName = "app-user",
        //                Email = appUserEmail,
        //                EmailConfirmed = true,
        //                Address = new Address()
        //                {
        //                    Street = "123 Main St",
        //                    City = "Charlotte",
        //                    State = "NC"
        //                }
        //            };
        //            await userManager.CreateAsync(newAppUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
        //        }

        //            //public static async Task CreateAdminUserAsync(
        //            //IServiceProvider provider)
        //            //{
        //            //    var roleManager =
        //            //        provider.GetRequiredService<RoleManager<IdentityRole>>();
        //            //    var userManager =
        //            //        provider.GetRequiredService<UserManager<User>>();

        //            //    string username = "Admin001";
        //            //    string password = "Password123";
        //            //    string roleName = "Admin";

        //            //    // if role doesn't exist, create it
        //            //    if (await roleManager.FindByNameAsync(roleName) == null)
        //            //    {
        //            //        await roleManager.CreateAsync(new IdentityRole(roleName));
        //            //    };


        //            //    // if username doesn't exist, create it and add to role
        //            //    if (await userManager.FindByNameAsync(username) == null)
        //            //    {
        //            //        User user = new User
        //            //        {
        //            //            UserName = username,
        //            //            Email = $"{username}@example.com",
        //            //            FirstName = "Admin",
        //            //            LastName = "User",
        //            //            Role = roleName
        //            //        };

        //            //        var result = await userManager.CreateAsync(user, password);
        //            //        if (result.Succeeded)
        //            //        {
        //            //            await userManager.AddToRoleAsync(user, roleName);
        //            //        }
        //            //        else
        //            //        {
        //            //            // Handle user creation failure (e.g., log errors)
        //            //            foreach (var error in result.Errors)
        //            //            {
        //            //                // Log or handle the error
        //            //                Console.WriteLine($"Error: {error.Description}");
        //            //            }
        //            //        }
        //            //  }
        //            //}

        //        }
        //}
        public static async Task CreateAdminUserAsync(IServiceProvider serviceProvider)
        {
            using (var serviceScope = serviceProvider.CreateScope())
            {
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<User>>();

                string adminUserEmail = "teddysmithdeveloper@gmail.com";
                string username = "teddysmithdev";
                string password = "Coding@1234?";
                string roleName = "Admin";

                // Create role if not exists
                if (await roleManager.FindByNameAsync(roleName) == null)
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }

                // Create admin user if not exists
                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new User
                    {
                        UserName = username,
                        Email = adminUserEmail,
                        EmailConfirmed = true,
                        FirstName = "Admin", // Ensure this is set
                        LastName = "User",  // Ensure this is set
                        FullName = "Admin User",
                        Gender = "Male",
                        RoleNames = new List<string> { "Admin" }
                    };
                    var result = await userManager.CreateAsync(newAdminUser, password);
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(newAdminUser, roleName);
                    }
                    else
                    {
                        // Handle errors
                        foreach (var error in result.Errors)
                        {
                            Console.WriteLine($"Error: {error.Description}");
                        }
                    }
                }

                // Create other users similarly...
            }


        }
    }
}