using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6_3_
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Masiv = { 2,4, 567,65,867 };

            int miniMasiv = Masiv[0];

            for (int a = 1; a < Masiv.Length; a++)
            {


                if (Masiv[a] < miniMasiv)
                {
                    miniMasiv = Masiv[a];
                }
            }
            Console.WriteLine("Наименьший массив"+"-"+miniMasiv);
            Console.ReadLine();
        }
    }
}
