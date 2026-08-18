using BlazorFrontEndProject.Models;

namespace BlazorFrontEndProject.Services
{
    public interface IProductService
    {
        Task<ProductListViewModel[]> GetProducts();

        Task Add(ProductViewModel ProductViewModel);

        Task Save(ProductViewModel productLiseViewModel);

        Task<ProductViewModel> GetProductById(int productId);
    }
}
