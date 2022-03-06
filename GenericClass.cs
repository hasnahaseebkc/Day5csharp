using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Gen<T>
    {
        public Gen(T msg)
        {
            Console.WriteLine(msg);
        }
        public void show<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }

    internal class GenericClass
    {
        static void Main(string[] args)
        {
            Gen<string> G1 = new Gen<string>("This is generic class");
            Gen<int> G2 = new Gen<int>(101);
            Gen<char> G3 = new Gen<char>('I');
            G1.show("\nThis is generic method");
            G1.show(10);
            G2.show('J');

            Console.ReadLine();
            
        }
    }
}
