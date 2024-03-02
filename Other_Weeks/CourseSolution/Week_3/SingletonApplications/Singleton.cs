using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApplications
{

    public class Singleton
    {
        // Static readonly instance
        private static readonly Singleton instance = new Singleton();

        // Private constructor to prevent instantiation from outside
        private Singleton()
        {
        }

        // Public method to get the singleton instance
        public static Singleton GetInstance()
        {
            return instance;
        }

        // Example method of the Singleton class
        public void SomeMethod()
        {
            Console.WriteLine("Executing SomeMethod...");

            // Example logic
            int result = Calculate(5, 3);
            Console.WriteLine("Result: " + result);
        }

        private int Calculate(int a, int b)
        {
            // Example calculation
            return a + b;
        }
    }
}
