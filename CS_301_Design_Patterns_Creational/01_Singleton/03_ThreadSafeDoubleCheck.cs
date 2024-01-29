using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Singleton
{
    public class ThreadSafeSingletonDoubleCheck
    {
        private static readonly object lockObject = new object();
        private static ThreadSafeSingletonDoubleCheck instance;

        private ThreadSafeSingletonDoubleCheck() { }

        public static ThreadSafeSingletonDoubleCheck Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new ThreadSafeSingletonDoubleCheck();
                        }
                    }
                }
                return instance;
            }
        }
    }

}
