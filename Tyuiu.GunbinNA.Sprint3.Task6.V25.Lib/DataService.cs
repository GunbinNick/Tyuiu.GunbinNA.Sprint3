using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.GunbinNA.Sprint3.Task6.V25.Lib
{
    public class DataService : ISprint3Task6V25
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int start = 16;
            int end = 24;
            int x;
            int sum = 0;
            for (x = start; x <= end; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0 && d < 10)
                        sum += d;
                }
            }
            return sum;
        }
    }
}
