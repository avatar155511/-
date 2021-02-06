using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите элементы массива ");
            int ckokM = int.Parse(Console.ReadLine());

            int[] masiv = new int[ckokM];

            for (int a = 0; a < masiv.Length; a++)
            {
                Console.WriteLine($"Введите элемент массива(индекс) {a}");
                masiv[a] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Вывод массива");

            for (int b = masiv.Length - 1; b >= 0; b--)
            {
                Console.WriteLine(masiv[b]);
            }
        }
    }
}
