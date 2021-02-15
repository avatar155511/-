using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ8__56_
{
    class Program
    {
        static void Resize(ref int[] bla, int dod)
        {
            int[] pudge = new int[dod];

            for (int i = 0; i < bla.Length && i < pudge.Length; i++)
            {
                pudge[i] = bla[i];
            }
            bla = pudge;
        }
        static void Main(string[] args)
        {
            int[] Dota = { 5, 1, 4, 6, 22 };


            Program.Resize(ref Dota, 12);



            Console.ReadLine();
        }

    }

}
    

