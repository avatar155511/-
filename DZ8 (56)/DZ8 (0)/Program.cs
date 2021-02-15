using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ8__0_
{
    class Program
    {
        static void crah(ref int[] array, int valw, int index)
        {
            int[] nu = new int[array.Length + 1];
            nu[index] = valw;

            for (int i = 0; i < index; i++)
                nu[i] = array[i];

            for (int i = index; i < array.Length; i++)
            {
                nu[i + 1] = array[i];

                array = nu;
            }
        }


        static void RP(ref int[] array, int valw)
        {
            crah(ref array, valw, 0);
        }
        static void Fp(ref int[] array, int valw, int index)
        {
            crah(ref array, valw, array.Length);
        }


        static void light(string[] args)
        {
            int[] skap = { 1, 9, 15, 8 };
            crah(ref skap, -2, 8);

        }
    }
}
    

