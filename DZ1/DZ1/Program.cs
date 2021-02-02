using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.WriteLine("Введите число 1");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            b = double.Parse(Console.ReadLine());
            double c = (a + b) / 2;
            Console.WriteLine(c);
            Console.ReadLine();


        }
    }
}
