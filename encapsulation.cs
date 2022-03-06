using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class person                //default internal access specifier
    {
        private string name;    //field
        string email;           //default private

        public string Name      //property (for name)
        {
            get { return name; }    //get method of property
            set { name = value; }   //set method of property

        }

        public person()     //default constructor (to initialise email)
        {
            email = "abc@xyz.com";
            Console.WriteLine(email);

        }

        public person(out int a)
        {
            a = 10;
        }
    }
    internal class encapsulation
    {
        static void Main(string[] args)
        {
            person p1 = new person();
            person p2 = new person(out int x);

            p1.Name = "Cathy";
            Console.WriteLine(p1.Name);

            Console.WriteLine(x);

            Console.ReadKey();

        }

    }
}
