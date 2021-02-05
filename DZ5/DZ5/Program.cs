using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину");
            int Dlina = int.Parse(Console.ReadLine());
            

            for (int a = 0; a < Dlina; a++)
            {
                for (int b = 0; b <= a; b++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();        
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            for (int a = 0; a < Dlina; a++)
            {
                for (int b = Dlina; b > a; b--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            for (int a = 0; a < Dlina; a++)
            {
                for (int b = Dlina; b > a; b--)
                {
                    Console.Write(" ");
                }
                for (int b = 0; b <= a; b++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            for (int a = 0; a < Dlina; a++)
            {
                for (int b = 0; b <= a; b++)
                {
                    Console.Write(" ");
                }
                for (int b = Dlina; b > a; b--)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }



            Console.ReadLine();
            
        }
    }
}
