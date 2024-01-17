
using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Data;
using System;
using User.Management.Service.Models;
using User.Management.Service.Models.Authentication.SignUp;
using Microsoft.Extensions.Configuration;

namespace User.Management.Service.Services
{
    public class UserManagement : IUserManagement
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserManagement(UserManager<IdentityUser> userManager,
                                        RoleManager<IdentityRole> roleManager,
                                        SignInManager<IdentityUser> signInManager
                                        )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        public async Task<ApiResponse<string>> CreateUserWithTokenAsync(RegisterUser registerUser)
        {
            var userExist = await _userManager.FindByEmailAsync(registerUser.Email);

            if (userExist != null)
            {
                return new ApiResponse<string> { IsSuccess = false, StatusCode = 403, Message = "User already exist!" };
            }

            IdentityUser user = new()
            {
                Email = registerUser.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = registerUser.Username,
                TwoFactorEnabled = true
            };

            if (await _roleManager.RoleExistsAsync(registerUser.Role))
            {
                var result = await _userManager.CreateAsync(user, registerUser.Password);

                if (!result.Succeeded)
                {
                    return new ApiResponse<string> { IsSuccess = false, StatusCode = 500, Message = "User Failed to Create!" };
                }

                await _userManager.AddToRoleAsync(user, registerUser.Role);

                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                return new ApiResponse<string> { IsSuccess = true, StatusCode = 201, Message = $"User created & Email sent to {user.Email} Successfully!", Response=token };
            }
            else
            {
                return new ApiResponse<string> { IsSuccess = false, StatusCode = 500, Message = "Provided role doesn't exist in the database!" };
            }
        }
    }
}
