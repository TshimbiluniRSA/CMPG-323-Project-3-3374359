using Data;
using Models;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        protected readonly SuperStoreContext _context = new();

        public IEnumerable<Customer> GetAll()
        {

            return _context.Customers.ToList();

        }

        void IGenericRepository<Customer>.Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<Customer>.AddRange(IEnumerable<Customer> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Customer> IGenericRepository<Customer>.Find(Expression<Func<Customer, bool>> expression)
        {
            throw new NotImplementedException();
        }

        Task<List<Customer>> ICustomerRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Customer> IGenericRepository<Customer>.GetAll()
        {
            throw new NotImplementedException();
        }

        Customer IGenericRepository<Customer>.getByID(int id)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<Customer>.Remove(Customer entity)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<Customer>.RemoveRange(IEnumerable<Customer> entities)
        {
            throw new NotImplementedException();
        }
    }
}
