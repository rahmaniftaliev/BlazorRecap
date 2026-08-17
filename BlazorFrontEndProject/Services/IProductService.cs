using BlazorFrontEndProject.Models;

namespace BlazorFrontEndProject.Services
{
    public interface IProductService
    {
        Task<ProductListViewModel[]> GetProducts();

        Task Add(ProductListViewModel productLiseViewModel);

        Task Save(ProductListViewModel productLiseViewModel);

        Task<ProductListViewModel> GetProductById(int productId);
    }
}
