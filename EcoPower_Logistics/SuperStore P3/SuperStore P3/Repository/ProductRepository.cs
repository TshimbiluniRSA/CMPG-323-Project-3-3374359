using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class ProductRepository
    {
        protected readonly SuperStoreContext _context = new();

        public IEnumerable<Product> GetAll()
        {

            return _context.Products.ToList();

        }
    }
}
