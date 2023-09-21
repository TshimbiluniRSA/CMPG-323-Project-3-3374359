using Models;

namespace EcoPower_Logistics.Repository
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<Product>> GetAll();
    }
}
