namespace MH.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private MHShopDbContext dbContext;

        public MHShopDbContext Init()
        {
            return dbContext ?? (dbContext = new MHShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}