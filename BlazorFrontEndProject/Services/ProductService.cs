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

        public async Task Add(ProductViewModel ProductViewModel)
        {
            await _httpClient.PostAsJsonAsync("https://localhost:44347/api/products/add", ProductViewModel);
        }

        public Task<ProductViewModel> GetProductById(int productId)
        {
            return _httpClient.GetFromJsonAsync<ProductViewModel>($"https://localhost:44347/api/products/getbyid?productid={productId}");
        }

        public Task<ProductListViewModel[]> GetProducts()
        {
            return _httpClient.GetFromJsonAsync<ProductListViewModel[]>("https://localhost:44347/api/products/getall");
        }

        public async Task Save(ProductViewModel ProductViewModel)
        {
            await _httpClient.PostAsJsonAsync("https://localhost:44347/api/products/update", ProductViewModel);
        }
    }
}
