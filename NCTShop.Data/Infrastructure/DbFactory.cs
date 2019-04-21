namespace NCTShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private NCTShopDbContext dbContext;

        public NCTShopDbContext Init()
        {
            return dbContext ?? (dbContext = new NCTShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}