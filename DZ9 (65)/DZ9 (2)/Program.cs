using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ9__2_
{
    class Program
    {
        static int H3(int value)
        {
            if (value < 10)
                return value;

            int dab = value % 10;
            int tab = value / 10;

            return dab + H3(tab);
        }

        static void Main3(string[] args)
        {
            int del = 561;

            int Finish = H3(del);
            Console.WriteLine("Поздравляю вы финишировали" + " " + Finish);


        }
    }
}
