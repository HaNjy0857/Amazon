using Amazon.DataAccess.Data;
using Amazon.DataAccess.Repository.IRepository;
using Amazon.Models;

namespace Amazon.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Product obj)
        {
            _db.Update(obj);
        }
    }
}
