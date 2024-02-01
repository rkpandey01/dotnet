using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Singleton
{
    public class Singleton
    {
        // Declare a private static instance 
        private static Singleton instance;

        //Make constructor private 
        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                // Add creation and access point for object
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }

}
