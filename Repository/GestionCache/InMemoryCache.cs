using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;

namespace Repository.GestionCache
{
    public class InMemoryCache : ICache
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cacheKey"></param>
        /// <param name="getData"></param>
        /// <returns></returns>
        public T GetOrSet<T>(string cacheKey, Func<T> getData)
        where T : class
        {

            T item = MemoryCache.Default.Get(cacheKey) as T;
            if (item == null)
            {
                item = getData();
                MemoryCache.Default.Add(cacheKey, item, DateTime.Now.AddHours(5));
            }
            return item;


        }

        /// <summary>
        /// Mise en cache
        /// </summary>
        /// <typeparam name="T">type generique</typeparam>
        /// <param name="cacheKey">Ma clé</param>
        /// <param name="objet">Mon objet à mettre en memoire</param>
        public void SetCache<T>(string cacheKey, T objet) where T : class
        {
            T item = MemoryCache.Default.Get(cacheKey) as T;
            if (item != null)
            {
                MemoryCache.Default.Remove(cacheKey);
            }


            MemoryCache.Default.Add(cacheKey, objet, DateTime.Now.AddHours(5));
        }

    }
}
