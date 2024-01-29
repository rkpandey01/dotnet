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
}
