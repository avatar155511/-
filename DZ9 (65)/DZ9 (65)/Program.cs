using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ9__65_
{
    class Program
    {
        static void H1(int[] My, int a = 0)
        {
            if (a < My.Length)
            {
                Console.WriteLine(My[a]);
                H1(My, a + 1);
            }
        }

        static void Main(string[] args)
        {
            int[] My = { 2, 1, 4, 6, 8 };
            H1(My);
        }
    }
}