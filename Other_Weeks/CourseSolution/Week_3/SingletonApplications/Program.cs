using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApplications
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get an instance of the Singleton
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            // Both instances should be the same
            Console.WriteLine(singleton1 == singleton2); // Output: True

            // Calling a method of the Singleton
            singleton1.SomeMethod(); // Output: Executing SomeMethod... Result: 2
            singleton2.SomeMethod(); // Output: Executing SomeMethod... Result: 3
            singleton1.SomeMethod(); // Output: Executing SomeMethod... Result: 4
            singleton1.SomeMethod(); // Output: Executing SomeMethod... Result: 5
            singleton2.SomeMethod(); // Output: Executing SomeMethod... Result: 6
            singleton1.SomeMethod(); // Output: Executing SomeMethod... Result: 7

            Console.ReadLine();
        }
    }
}
