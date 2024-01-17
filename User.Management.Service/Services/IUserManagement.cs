
using User.Management.Service.Models;
using User.Management.Service.Models.Authentication.SignUp;

namespace User.Management.Service.Services
{
    public interface IUserManagement
    {
        /// <summary>
        /// Bief description of what the method does.
        /// </summary>
        /// <param name="registerUser">Description of the parameter</param>
        /// <returns>Description of the return value</returns>
        Task<ApiResponse<string>> CreateUserWithTokenAsync(RegisterUser registerUser);
    }
}
