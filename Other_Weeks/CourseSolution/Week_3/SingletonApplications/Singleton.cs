using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

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
