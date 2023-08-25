namespace Amazon.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository categoryRepository { get; }
        void Save();
    }
}
