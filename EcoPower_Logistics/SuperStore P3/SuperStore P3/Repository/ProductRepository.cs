using Data;
using Models;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Repository
{
    public class ProductRepository : IProductRepository
    {
        protected readonly SuperStoreContext _context = new();

        public IEnumerable<Product> GetAll()
        {

            return _context.Products.ToList();

        }

        void IGenericRepository<Product>.Add(Product entity)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<Product>.AddRange(IEnumerable<Product> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Product> IGenericRepository<Product>.Find(Expression<Func<Product, bool>> expression)
        {
            throw new NotImplementedException();
        }

        Task<List<Product>> IProductRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Product> IGenericRepository<Product>.GetAll()
        {
            throw new NotImplementedException();
        }

        Product IGenericRepository<Product>.getByID(int id)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<Product>.Remove(Product entity)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<Product>.RemoveRange(IEnumerable<Product> entities)
        {
            throw new NotImplementedException();
        }
    }
}
