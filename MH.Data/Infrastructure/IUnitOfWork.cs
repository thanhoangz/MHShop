namespace MH.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}