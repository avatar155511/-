using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ7__1_
{
    class Program
    {
        static int index(int [] array, int ilya)
        {
            for (int a = 0; a < array.Length; a++)
            {
                if (array[a] == ilya)
                {
                    return a;
                }
                
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arrayI = { 5, 7, 29, 234, 764, 949 };

            int result = index(arrayI, 764);

            Console.WriteLine(result);
        }
    }
}
