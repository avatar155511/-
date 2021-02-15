using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ7__46_
{
    class Program
    {
        static void otvet(string bla, uint noranch)
        {
            for (int a = 0; a < noranch; a++)
            {
                Console.WriteLine(bla);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ");
            string bla = Console.ReadLine();

            Console.WriteLine("Введите кол-во символов");
            uint noranch = uint.Parse(Console.ReadLine());

            Program.otvet(bla, noranch);
            Console.ReadLine();
        }
    }
}
