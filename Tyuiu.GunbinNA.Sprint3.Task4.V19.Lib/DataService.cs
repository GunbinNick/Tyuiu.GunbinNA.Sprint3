using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GunbinNA.Sprint3.Task4.V19.Lib
{
    public class DataService : ISprint3Task4V19
    {
        public double Calculate(int startValue, int stopValue)
        {
            int start = -5;
            int end = 5;
            double res = 1;
            for (int x = start; x <= end; x++)
            {
                if (x == 0)
                    break;
                else
                    res *= x / (Math.Cos(x) + x) + 0.5;
            }
            return Math.Round(res, 3);
        }
    }
}
