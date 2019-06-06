using System;

namespace Repository.GestionCache
{
    public interface ICache
    {
        T GetOrSet<T>(string cacheKey, Func<T> getData) where T : class;
    }
}