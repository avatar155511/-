using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ9__1_
{
    class Program
    {
        static int H2(int[] sum, int i = 0)
        {
            if (i >= sum.Length)
                return 0;
            int summa = H2(sum, i + 1);
            return sum[i] + summa;

        }

        static void Main1(string[] args)
        {
            int[] sum = { 7, 9, 2 };
            int summa = H2(sum);
            Console.WriteLine(summa);
        }
    }
}
