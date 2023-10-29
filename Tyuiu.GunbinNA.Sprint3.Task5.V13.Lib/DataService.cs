using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GunbinNA.Sprint3.Task5.V13.Lib
{
    public class DataService : ISprint3Task5V13
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            int start1 = 1;
            int end1 = 3;
            int start2 = 1;
            int end2 = 12;
            double res1 = 0;
            double res2 = 0;
            for (int i = start1; i <= end1; i++)
            {
                for (int j = start2; j <= end2; j++)
                {
                    res2 += Math.Cos(x) + j / 2;
                }
                res1 += res2;
            }
            return Math.Round(res1, 3);
        }
    }
}
