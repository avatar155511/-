using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Введите число 1");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 3");
            c = double.Parse(Console.ReadLine());
            double d = a + b + c;
            double e = a * b * c;

            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.ReadLine();
        }
        
    }
}
