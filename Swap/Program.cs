using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(1,101);
            int b = rnd.Next(1, 101);
            Console.WriteLine($"{a} {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"{a} {b}");
            Console.ReadKey();
        }
    }
}
