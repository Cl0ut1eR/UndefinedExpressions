using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndefinedExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Infinity infinity = new Infinity(4);
            Infinity infinity2 = new Infinity(new Infinity(new Infinity(2)));
            Number number = infinity * infinity2;
            Console.WriteLine(number.ToString());
            Console.ReadLine();
        }
    }
}
