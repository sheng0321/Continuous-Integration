using ConestogaVirtualGameStore.Server.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ConestogaVirtualGameStore.Server.Data.Helpers
{
    public static class AdminUserSeeder
    {
        public static async Task SeedAdminUser(
    UserManager<ApplicationUser> userManager,
    RoleManager<IdentityRole> roleManager,
    string adminEmail = "Admin@cvgs.com",
    string adminPassword = "Admin@123",
    string displayName = "Admin", // New parameter for display name
    string adminRole = "Admin")
        {
            // Ensure the Admin role exists
            if (!await roleManager.RoleExistsAsync(adminRole))
            {
                throw new Exception($"Role '{adminRole}' does not exist.");
            }

            // Check if the admin user exists
            var adminUser = await userManager.FindByEmailAsync(adminEmail);
            if (adminUser == null)
            {
                // Create the admin user
                adminUser = new ApplicationUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true,
                    DisplayName = displayName // Set the display name
                };

                var result = await userManager.CreateAsync(adminUser, adminPassword);
                if (!result.Succeeded)
                {
                    throw new Exception("Failed to create admin user: " +
                        string.Join(", ", result.Errors.Select(e => e.Description)));
                }
            }
            else
            {
                // If the admin user exists, update the display name if it's different
                if (adminUser.DisplayName != displayName)
                {
                    adminUser.DisplayName = displayName;
                    var updateResult = await userManager.UpdateAsync(adminUser);
                    if (!updateResult.Succeeded)
                    {
                        throw new Exception("Failed to update admin user display name: " +
                            string.Join(", ", updateResult.Errors.Select(e => e.Description)));
                    }
                }
            }

            // Ensure the admin user is in the Admin role
            if (!await userManager.IsInRoleAsync(adminUser, adminRole))
            {
                var result = await userManager.AddToRoleAsync(adminUser, adminRole);
                if (!result.Succeeded)
                {
                    throw new Exception($"Failed to assign role '{adminRole}' to admin user: " +
                        string.Join(", ", result.Errors.Select(e => e.Description)));
                }
            }
        }


        private static async Task EnsureRoleExists(RoleManager<IdentityRole> roleManager, string role)
        {
            if (!await roleManager.RoleExistsAsync(role))
            {
                var result = await roleManager.CreateAsync(new IdentityRole(role));
                if (!result.Succeeded)
                {
                    throw new Exception($"Failed to create role {role}: " +
                        string.Join(", ", result.Errors.Select(e => e.Description)));
                }
            }
        }

        private static async Task EnsureAdminUserExists(UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager, string email, string password, string role)
        {
            var user = await userManager.FindByEmailAsync(email);

            if (user == null)
            {
                // Create the admin user if not found
                user = new ApplicationUser
                {
                    UserName = email,
                    Email = email,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, password);
                if (!result.Succeeded)
                {
                    throw new Exception($"Failed to create admin user: " +
                        string.Join(", ", result.Errors.Select(e => e.Description)));
                }
            }

            // Ensure the user is in the specified role
            if (!await userManager.IsInRoleAsync(user, role))
            {
                var result = await userManager.AddToRoleAsync(user, role);
                if (!result.Succeeded)
                {
                    throw new Exception($"Failed to assign role {role} to admin user: " +
                        string.Join(", ", result.Errors.Select(e => e.Description)));
                }
            }
        }
    }
}

