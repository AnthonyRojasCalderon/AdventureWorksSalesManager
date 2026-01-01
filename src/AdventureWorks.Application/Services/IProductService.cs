using AdventureWorks.Application.DTOs;

namespace AdventureWorks.Application.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();
    }
}
