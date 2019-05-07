using MH.Data.Infrastructure;
using MH.Model.Models;

namespace MH.Data.Repositories
{ 
    public interface IProductRepository : IRepository<Product>
    {
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}