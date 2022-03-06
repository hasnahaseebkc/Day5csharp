using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Calculator
    {
        public static bool AreEqual(object value1, object value2)       //object reference
        {
            return value1 == value2;
        }

    }

    internal class GenericClass2
    {
        private static void Main()
        {
            bool isEqual = Calculator.AreEqual(10, 20);
            bool isEqual1 = Calculator.AreEqual("ABC", "ABC");

            if (isEqual)
                Console.WriteLine("Both are equal");
            else
                Console.WriteLine("Both are not equal");


            if(isEqual1)
                Console.WriteLine("Both are equal");
            else
                Console.WriteLine("Both are not equal");

            Console.ReadKey();
        }
    }
}

//Lets see the problem of the above code implementation
//We get poor performance due to boxing and unboxing
//The object type needs to be converted to the value type
//Now, the AreEqual() method is not type - safe
//Now it is possible to pass a string value for the first parameter and an integer value for the second parameter.



