using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            char znak;
            double b;
            double primer;

            Console.WriteLine("Введите 1 число");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите что вы хотите сделать с числом (+),(-),(*),(/)");
            znak = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите 2 число");
            b = Convert.ToDouble(Console.ReadLine());

            if (znak == '+')
            {
                primer = a + b;
                Console.WriteLine("Сумма" + a + "+" + b + "=" + primer);
            }
                else if (znak == '-')
            {
                primer = a - b;
                Console.WriteLine("Разность" + a + "-" + b + "=" + primer);
            }
            else if (znak == '*')
            {
                primer = a * b;
                Console.WriteLine("Произведение" + a + "*" + b + "=" + primer);
            }
            else if (znak == '/')
            {
                primer = a / b;
                Console.WriteLine("Частное" + a + "/" + b + "=" + primer);
            }
        }
    }
}
