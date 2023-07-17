using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230717
{
    internal class Program
    {
        static void refSwap(ref int a, ref int b)
        {
            int c = 0;

            c = b;
            b = a;
            a = c;
        }

        static void outSwap(int x, int y, out int outSwapValueX, out int outSwapValueY)
        {
            int c = 0;

            c = y;
            y= x;
            x = c;

            outSwapValueX = x; 
            outSwapValueY = y;
        }

        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 6;
            refSwap(ref a, ref b);
            int outC = 0;
            int outD = 0;
            outSwap(c, d, out outC, out outD);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(outC);
            Console.WriteLine(outD);



        }
    }
}
