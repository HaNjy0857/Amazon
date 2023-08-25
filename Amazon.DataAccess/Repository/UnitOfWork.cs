using Amazon.DataAccess.Repository.IRepository;

namespace Amazon.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork()
        {

        }
        public ICategoryRepository categoryRepository { get; private set; }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
