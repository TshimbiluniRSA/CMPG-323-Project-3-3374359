using Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class OrderRepository
    {
        protected readonly SuperStoreContext _context = new();

        public IEnumerable<Order> GetAll() {
            
            return _context.Orders.ToList();
            
        }

    }
}
