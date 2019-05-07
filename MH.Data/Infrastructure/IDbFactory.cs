using System;

namespace MH.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        MHShopDbContext Init();
    }
}