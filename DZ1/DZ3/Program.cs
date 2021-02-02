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
            

            Console.WriteLine("Какое количество валюты вы хотите конвертировать?");
            int rub = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("В какую валюту конвертировать? (1)евро,(2)доллор,(3)юань");
            int pick = Convert.ToInt32(Console.ReadLine());
            switch (pick)
            {
                case 1:
                    Console.WriteLine("Ваша сумма в евро равна " + (rub * 80));
                    break;
                case 2:
                    Console.WriteLine("Ваша сумма в Долларах равна " + (rub * 70));
                    break;
                case 3:
                    Console.WriteLine("Ваша сумма в евро равна " + (rub * 10));
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;

            }
            Console.ReadLine();
        }
    }
}
