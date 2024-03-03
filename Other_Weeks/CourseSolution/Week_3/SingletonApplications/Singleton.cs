using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SingletonApplications
{
    //    ** Design patterns** are typical solutions to commonly occurring problems in software design.
    //    They are like pre-made blueprints that you can customize to solve a recurring design problem in your code.

    //You can’t just find a pattern and copy it into your program, the way you can with off-the-shelf functions or libraries.
    //The pattern is not a specific piece of code, but a general concept for solving a particular problem.
    //You can follow the pattern details and implement a solution that suits the realities of your own program.

    //Patterns are often confused with algorithms, because both concepts describe typical solutions to some known problems.
    //While an algorithm always defines a clear set of actions that can achieve some goal, a pattern is a more high-level
    //description of a solution.The code of the same pattern applied to two different programs may be different.

    //An analogy to an algorithm is a cooking recipe: both have clear steps to achieve a goal. On the other hand,
    //a pattern is more like a blueprint: you can see what the result and its features are, but the exact order
    //of implementation is up to you.


//    The Singleton pattern solves two problems at the same time, violating the* Single Responsibility Principle*:

//1. ** Ensure that a class has just a single instance**. Why would anyone want to control how many instances a class has?
//The most common reason for this is to control access to some shared resource—for example, a database or a file.
//    Here’s how it works: imagine that you created an object, but after a while decided to create a new one.
//    Instead of receiving a fresh object, you’ll get the one you already created.

//    Note that this behavior is impossible to implement with a regular constructor since a constructor call** must** 
//    always return a new object by design.
        
//    1. ** Provide a global access point to that instance**. Remember those global variables that you(all right, me)
//    used to store some essential objects? While they’re very handy, they’re also very unsafe since any code can potentially
//    overwrite the contents of those variables and crash the app.

//        Just like a global variable, the Singleton pattern lets you access some object from anywhere in the program.
//        However, it also protects that instance from being overwritten by other code.

//        There’s another side to this problem: you don’t want the code that solves problem #1 to be scattered all
//        over your program. It’s much better to have it within one class, especially if the rest of your code already depends on it.
        
    
//    Nowadays, the Singleton pattern has become so popular that people may call something a* singleton* even if it
//    solves just one of the listed problems.

//    ## **Solution**

//    All implementations of the Singleton have these two steps in common:
    
//    - Make the default constructor private, to prevent other objects from using the `new` operator with
//    the Singleton class.
//    - Create a static creation method that acts as a constructor.Under the hood, this method calls the private
//    constructor to create an object and saves it in a static field.All following calls to this method return the cached object.


//    If your code has access to the Singleton class, then it’s able to call the Singleton’s static method.
//    So whenever that method is called, the same object is always returned.
    
//    **Real-World Analogy**


//    Türkiye singletondur. Her bir kişinin ülkesi vardır.A kişisi de ülkeye sahiptir B kişisi de ama
//    hepsi aslında 1 tane türkiye vardır ve ona sahiptirler.
    
//    ## **Applicability**
    
//    **Use the Singleton pattern when a class in your program should have just a single instance available
//    to all clients; for example, a single database object shared by different parts of the program.**
    
//    The Singleton pattern disables all other means of creating objects of a class except for the
//    special creation method.This method either creates a new object or returns an existing one if it has already been created.


//    ** Use the Singleton pattern when you need stricter control over global variables.**

//    Unlike global variables, the Singleton pattern guarantees that there’s just one instance of
//    a class. Nothing, except for the Singleton class itself, can replace the cached instance.

//    Note that you can always adjust this limitation and allow creating any number of Singleton
//    instances.The only piece of code that needs changing is the body of the `getInstance` method.
    
//    ## **How to Implement**
    
//    1. Add a private static field to the class for storing the singleton instance.
//    2. Declare a public static creation method for getting the singleton instance.
//    3. Implement “lazy initialization” inside the static method.It should create a new object
//    on its first call and put it into the static field.The method should always return that
//    instance on all subsequent calls.
//    4. Make the constructor of the class private. The static method of the class will still be
//    able to call the constructor, but not the other objects.
//    5. Go over the client code and replace all direct calls to the singleton’s constructor with
//    calls to its static creation method.
    
//    **Structure**
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
