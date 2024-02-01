using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Proxy
{
    // ProxyDatabase class
    public class ProxyDatabase : IDatabase
    {
        private RealDatabase realDatabase;
        private List<string> cachedQueries = new List<string>();

        public void ExecuteQuery(string query)
        {
            if (realDatabase == null)
            {
                realDatabase = new RealDatabase();
            }

            if (cachedQueries.Contains(query))
            {
                Console.WriteLine($"Query '{query}' found in cache. Retrieving from cache.");
            }
            else
            {
                Console.WriteLine($"Query '{query}' not found in cache. Executing and caching result.");
                realDatabase.ExecuteQuery(query);
                cachedQueries.Add(query);
            }
        }
    }

}
