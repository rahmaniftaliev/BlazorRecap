using BlazorFrontEndProject.Models;
using System.Net.Http.Json;

namespace BlazorFrontEndProject.Services
{
    public class CategoryService : ICategoryService
    {
        private HttpClient _httpClient;

        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public Task<CategoryListViewModel[]> GetCategories()
        {
            return _httpClient.GetFromJsonAsync<CategoryListViewModel[]>("https://localhost:44347/api/categories/getall");
        }
    }
}
