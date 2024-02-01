using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Singleton
{
    public class LazySingleton
    {
        private static readonly Lazy<LazySingleton> lazyInstance = new Lazy<LazySingleton>(() => new LazySingleton());

        private LazySingleton() { }

        public static LazySingleton Instance => lazyInstance.Value;
    }

    /*
     * Here's what happens step by step:
     * When the Lazy<MyClass> object is created, it doesn't immediately initialize the MyClass instance.
     * When you access the Value property of the Lazy<MyClass> object, the MyClass instance is created and initialized for the first time.
     * Subsequent accesses to the Value property will reuse the already initialized MyClass instance.

     * */
}
