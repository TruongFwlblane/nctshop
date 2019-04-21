using System;

namespace NCTShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        NCTShopDbContext Init();
    }
}