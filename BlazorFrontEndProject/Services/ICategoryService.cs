using BlazorFrontEndProject.Models;

namespace BlazorFrontEndProject.Services
{
    public interface ICategoryService
    {
        Task<CategoryListViewModel[]> GetCategories();
    }
}
