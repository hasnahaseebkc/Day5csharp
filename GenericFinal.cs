using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //Let us create a generic class with a generic constructor, generic member variables and a generic method as shown below

    //GenericFinal is a generic class
    class GenericFinal<T>
    {

        //Generic variable
        //The datatype is generic
        private T genericMemberVariable;

        //Generic constructor
        //Constructor accepts one parameter of generic type
        public GenericFinal(T value)
        {
            genericMemberVariable = value;  //10
        }

        //Generic method
        //Method accepts one generic type parameter
        //Method return type also generic
        public T genericMethod(T genericParameter)      //200
        {
            //PT:System.Int32,200
            Console.WriteLine("Parameter type: {0}, Value: {1}", typeof(T).ToString(), genericParameter);
            //RT:System.Int32,10
            Console.WriteLine("Return type: {0}, Value: {1}", typeof(T).ToString(), genericMemberVariable);
            return genericMemberVariable;
        }

        //Generic Property
        //The datatype is generic
        public T genericProperty { get; set; }
       
    }

    class FinalGenericcls
    {
        static void Main()
        {
            GenericFinal<int> integerGenericClass = new GenericFinal<int>(10);
            int val = integerGenericClass.genericMethod(200);
            Console.WriteLine(val);

            GenericFinal<string> stringGenericClass = new GenericFinal<string>("Hello");
            string val1 = stringGenericClass.genericMethod("World");
            Console.WriteLine(val1);

            Console.ReadKey();

        }
    }
}
