using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace прова
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите кол-во Валюты :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите тип валюты :");
            Console.WriteLine("1.Из Евро в рубли ");
            Console.WriteLine("2.Из Доллара в рубли ");
            int caseSwitch = Convert.ToInt32(Console.ReadLine());
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Ваша сумма в евро равна " + (a * 92));
                    break;
                case 2:
                    Console.WriteLine("Ваша сумма в Долларах равна " + (a * 76));
                    break;
                default:
                    Console.WriteLine("Такой валюты не завезли");
                    break;
            }
        
        }
    }
}
