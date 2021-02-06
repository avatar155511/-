using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите элементы массива ");
            int ckokM = int.Parse(Console.ReadLine());

            int[] Masiv = new int[ckokM];

            for (int a = 0; a < Masiv.Length; a++)
            {
                Console.WriteLine($"Введите элемент массива(индекс) {a}");
                Masiv[a] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Вывод массива");

            for (int b = 0; b < Masiv.Length; b++)
            {
                Console.WriteLine(Masiv[b]);
            }

        }
    }
}
