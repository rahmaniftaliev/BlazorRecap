using BlazorFrontEndProject.Models;
using System.Net.Http.Json;

namespace BlazorFrontEndProject.Services
{
    public class ProductService : IProductService
    {

        private HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task Add(ProductListViewModel productLiseViewModel)
        {
            await _httpClient.PostAsJsonAsync("https://localhost:44347/api/products/add", productLiseViewModel);
        }

        public Task<ProductListViewModel> GetProductById(int productId)
        {
            return _httpClient.GetFromJsonAsync<ProductListViewModel>($"https://localhost:44347/api/products/{productId}");
        }

        public Task<ProductListViewModel[]> GetProducts()
        {
            return _httpClient.GetFromJsonAsync<ProductListViewModel[]>("https://localhost:44347/api/products/getall");
        }

        public async Task Save(ProductListViewModel productLiseViewModel)
        {
            await _httpClient.PostAsJsonAsync("https://localhost:44347/api/products/add", productLiseViewModel);
        }
    }
}
