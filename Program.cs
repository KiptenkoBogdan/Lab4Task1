using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            A obj1 = new A();
            float c = obj1.C;
            Console.WriteLine("a*b = {0}", c);
            Console.ReadKey();
        }
    }
}
