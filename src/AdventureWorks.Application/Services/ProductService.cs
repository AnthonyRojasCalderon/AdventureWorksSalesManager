using AdventureWorks.Application.DTOs;
using AdventureWorks.Domain.Interfaces;

namespace AdventureWorks.Application.Services
{
    public class ProductService : IProductService
    {
        public readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            var product = await _repository.GetAllAsync();

            return product.Select(p => new ProductDto
            {
                ProductID = p.ProductId,
                Name = p.Name,
                ProductNumber = p.ProductNumber,
                Color = p.Color,
                ListPrice = p.ListPrice
            });
        }
    }
}
