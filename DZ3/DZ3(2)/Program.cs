using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double a;
            double b;
            double resultat;
            string znak;
            Console.WriteLine("Введите число");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите (+),(-),(*),(/).");
            znak = Console.ReadLine();

            switch(znak)
            {
                case "+":
                    resultat = a + b;
                    Console.WriteLine(resultat);

                    break;

                case "-":
                    resultat = a - b;
                    Console.WriteLine(resultat);
                    break;

                case "*":
                    resultat = a * b;
                    Console.WriteLine(resultat);
                    break;

                case "/":
                    resultat = a / b;
                    Console.WriteLine(resultat);
                    break;



            }
            


        }
        
    }
}
