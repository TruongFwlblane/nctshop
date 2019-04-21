namespace NCTShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}