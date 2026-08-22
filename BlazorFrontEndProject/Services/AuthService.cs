using BlazorFrontEndProject.Models;
using System.Net.Http.Json;

namespace BlazorFrontEndProject.Services
{
    public class AuthService : IAuthService
    {
        private HttpClient _httpClient;
        public bool IsLoggedIn { get; set; }

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task Login(LoginModel loginModel)
        {
            var response = await _httpClient.PostAsJsonAsync<TokenModel>("https://localhost:44347/api/auth/login", loginModel);
            if (!String.IsNullOrEmpty(response.Token))
            {
               IsLoggedIn = true;
            }
        }

        public async Task Logout()
        {
            IsLoggedIn = false;
        }
    }
}
