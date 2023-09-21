using Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Repository
{
    public class OrderRepository : IOrderRepository
    {
        protected readonly SuperStoreContext _context = new();

        public IEnumerable<Order> GetAll() {
            
            return _context.Orders.ToList();
            
        }

        void IGenericRepository<Order>.Add(Order entity)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<Order>.AddRange(IEnumerable<Order> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Order> IGenericRepository<Order>.Find(Expression<Func<Order, bool>> expression)
        {
            throw new NotImplementedException();
        }

        Task<List<Order>> IOrderRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Order> IGenericRepository<Order>.GetAll()
        {
            throw new NotImplementedException();
        }

        Order IGenericRepository<Order>.getByID(int id)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<Order>.Remove(Order entity)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<Order>.RemoveRange(IEnumerable<Order> entities)
        {
            throw new NotImplementedException();
        }
    }
}
