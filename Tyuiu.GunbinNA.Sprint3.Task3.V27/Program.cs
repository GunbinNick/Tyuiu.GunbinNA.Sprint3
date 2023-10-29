using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GunbinNA.Sprint3.Task2.V27.Lib;

namespace Tyuiu.GunbinNA.Sprint3.Task3.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double sp = 0;
            int i = 0;
            for (x = -2; x <= 2; x++)
            {
                if (x == 0)
                    continue;
                sp = sp * (2*x / x);
                i++;

            }
            Console.WriteLine(sp);
            Console.ReadKey();
        }
    }
}
