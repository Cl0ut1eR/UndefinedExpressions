using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndefinedExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Infinity infinity = new Infinity(4);
            //Infinity infinity2 = new Infinity(new Infinity(new Infinity(2)));
            Zero zero = new Zero(1);
            Number number = 3*2*zero * 3;
            Console.WriteLine(number.ToString());
            number = number / zero;
            Console.WriteLine(number.ToString());
            Console.ReadLine();
        }
    }
}
