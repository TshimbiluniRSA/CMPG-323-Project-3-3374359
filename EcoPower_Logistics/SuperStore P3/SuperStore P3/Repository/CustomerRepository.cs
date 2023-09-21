using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class CustomerRepository
    {
        protected readonly SuperStoreContext _context = new();

        public IEnumerable<Customer> GetAll()
        {

            return _context.Customers.ToList();

        }
    }
}
