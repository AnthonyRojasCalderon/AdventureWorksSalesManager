using AdventureWorks.Domain.Entities;
using AdventureWorks.Domain.Interfaces;
using AdventureWorks.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public readonly AdventureWorksContext _context;

        public ProductRepository(AdventureWorksContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
           return await _context.Products.Where(p => p.SellEndDate != null || p.SellEndDate > DateTime.Now).Take(50).ToListAsync();
        }
    }
}
