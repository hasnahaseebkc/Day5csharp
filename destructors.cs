using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class destructors
    {
        static void Main()
        {
            Third t = new Third();          //Object creation of derived class

            Console.ReadKey();

        }
    }

    class First
    {
        public First()      //Constructor
        {
            Console.WriteLine("This is Base First Constructor");
        }

        ~First()            //Destructor
        {
            Console.WriteLine("This is First Destructor");
        }

    }

    class Second : First        //single level inheritance
    {
        public Second()         //Constructor
        {
            Console.WriteLine("This is Second Constructor,derived for First, base for Third");
        }

        ~Second()               //Destructor
        {
            Console.WriteLine("This is Second Destructor");
        }


    }

    class Third : Second            //multi-level inheritance
    {
        public Third()          //Constructor
        {
            Console.WriteLine("This is Derived Third Constructor");
        }

        ~Third()                //Destructor
        {
            Console.WriteLine("This is Third Destructor");
        }

    }

}
