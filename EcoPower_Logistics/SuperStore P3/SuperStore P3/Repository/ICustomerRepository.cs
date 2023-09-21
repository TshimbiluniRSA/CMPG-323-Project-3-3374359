using Models;

namespace EcoPower_Logistics.Repository
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        new Task<List<Customer>> GetAll();
    }
}
