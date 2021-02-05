using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    class Program
    {
        static void Main(string[] args)
        {
            uint a1 = 0;
            uint b1 = 0;


            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            
            
            
            while (a < b)

            {
                a++;
                Console.WriteLine(a);

                if (a % 2 == 0)
                {
                    a1++;
                }
                else
                {
                    b1++;
                }
                
                
         
            }
            Console.WriteLine("Кол-во четных чисел"+"-"+ a1);
            Console.WriteLine("Кол-во не четных чисел"+"-" + b1);
            Console.ReadLine();
        }
        
    }
}
