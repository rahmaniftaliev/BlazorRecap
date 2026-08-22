using BlazorFrontEndProject.Models;

namespace BlazorFrontEndProject.Services
{
    public interface IAuthService
    {

        Task Login(LoginModel loginModel);
        Task Logout();

    }
}