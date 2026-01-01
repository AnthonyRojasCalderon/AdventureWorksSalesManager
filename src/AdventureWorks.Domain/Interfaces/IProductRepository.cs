using AdventureWorks.Domain.Entities;

namespace AdventureWorks.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
    }
}
