using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Proxy
{
    // RealDatabase class
    public class RealDatabase : IDatabase
    {
        public void ExecuteQuery(string query)
        {
            // Simulate expensive database operation
            Console.WriteLine($"Executing query: {query}");
            // Actual database interaction code would be here
        }
    }

}
