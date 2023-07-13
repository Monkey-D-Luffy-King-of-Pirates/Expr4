using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr4
{
    internal class Program
    {
        static int Counter (int number, int divider1, int divider2)
        {
            return (number - 1) / divider1 + (number - 1) / divider2 - (number - 1) / (divider1 * divider2);
            //int b;
            //number = number - 1;
            //b = divider1 * divider2;
            //divider1 = number / divider1;
            //divider2 = number / divider2;
            //divider1 = divider1 + divider2;
            //divider2 = number / b;
            //return divider1 - divider2;

        }
        static void Main(string[] args)
        {
            int a = Counter(100, 3, 5);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
