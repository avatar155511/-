using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ8__1_
{
    class Program
    {
        static void mov(ref int[] array, int index)
        {
            int[] ful = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
                ful[i] = array[i];

            for (int i = index + 1; i < array.Length; i++)
                ful[i - 1] = array[i];

            array = ful;
        }

        static void fics(ref int[] array)
        {
            mov(ref array, 0);
        }


        static void last(ref int[] array)
        {
            mov(ref array, array.Length - 1);
        }


        static void NoMain(string[] args)
        {
            int[] myArray = { 2, 5, 4, 1 };
        }
    }
}
