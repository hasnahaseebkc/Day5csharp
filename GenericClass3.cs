using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class GenericClass3
    {
        private static void Main()
        {
            bool isEqual1 = Calculator.AreEqual(10, 20);
            bool isEqual2 = Calculator.AreEqual("ABC", "ABC");
            bool isEqual3 = Calculator.AreEqual(10.5, 20.5);

            if (isEqual1)
                Console.WriteLine("Both are equal");
            else
                Console.WriteLine("Both are not equal");

            if (isEqual2)
                Console.WriteLine("Both are equal");
            else
                Console.WriteLine("Both are not equal");

            if (isEqual3)
                Console.WriteLine("Both are equal");
            else
                Console.WriteLine("Both are not equal");

            Console.ReadKey();
        }
    }

    public class Calculator1
    {
        public static bool AreEqual(int value1, int value2)   
        {
            return value1 == value2;
        }

        public static bool AreEqual(string value1, string value2)   
        {
            return value1 == value2;
        }

        public static bool AreEqual(double value1, double value2)     
        {
            return value1 == value2;
        }

    }
}

//The problem with the above code implementation is ThreadStaticAttribute we are repeating the same logic in each and every method 
//However if tomorrow we need to compare two float or two long values then again we need to create two more methods.

//We can solve all the above problems with Generics in C#.
//With generics we will make the AreEqual() method to work with different types of datatypes.


