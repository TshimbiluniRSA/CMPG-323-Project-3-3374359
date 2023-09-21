using Models;

namespace EcoPower_Logistics.Repository
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        Task<List<Customer>> GetAll();
    }
}
