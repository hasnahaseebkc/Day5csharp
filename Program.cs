using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //******************************CONSTUCTORS*********************
    class car
    {
        public int carno;
        public string carName, color;

        public car()    //default constructor
        {
            Console.WriteLine("This is a default constructor.");
            carno = 1;
            carName = "Swift";
            color = "White";

        }

        static car()
        {
            Console.WriteLine("This is a Static constructor executed only once.\n");        //static constructor
        }

        public car(int cno, string cname, string clr)   //parametrised constructor
        {
            Console.WriteLine();
            Console.WriteLine("This is a parametrized constructor.");
            carno = cno;
            carName = cname;
            color = clr;
        }

        

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car c1 = new car();
            Console.WriteLine(c1.carno + " " + c1.carName + " " + c1.color);

            car c2 = new car(2,"Skoda","Grey");
            Console.WriteLine(c2.carno + " "+ c2.carName + " "+ c2.color);

            car c3 = c2;
            Console.WriteLine("\nThis is a copy constructor\n" + c3.carno + " " + c3.carName + " " + c3.color);

            Console.ReadLine();

        }
    }
}
