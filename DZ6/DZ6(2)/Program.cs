using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите элементы массива ");
            int ckokM = int.Parse(Console.ReadLine());

            int[] masiv = new int[ckokM];
            int result = 0;
            for (int a = 0; a < masiv.Length; a++)
            {
                Console.WriteLine($"Введите элемент массива(индекс) {a}");
                masiv[a] = int.Parse(Console.ReadLine());

                if (masiv[a] % 2 == 0)
                {
                    result += masiv[a];
                }
            }
            Console.WriteLine("Сумма четных чисел" + "=" + result);
            Console.ReadLine();


        }
    }
}