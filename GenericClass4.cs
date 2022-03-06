using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class GenericClass4
    {
        private static void Main()
        {
            bool isEqual1 = Calculator.AreEqual(10, 20);
            //bool isEqual2 = Calculator.AreEqual("ABC", "ABC");
            //bool isEqual3 = Calculator.AreEqual(10.5, 20.5);

            if (isEqual1)
                Console.WriteLine("Both are equal");
            else
                Console.WriteLine("Both are not equal");

            Console.ReadKey();

        }
    }

    public class Calculator2
    {
        public static bool AreEqual<T>(T value1, T value2)
                //public static bool AreEqual<T, T1>(T value1, T1 value2)
        {
            return value1.Equals(value2);
        }
    }
}
