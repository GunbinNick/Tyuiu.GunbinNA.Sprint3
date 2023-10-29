using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GunbinNA.Sprint3.Task7.V19.Lib
{
    public class DataService : ISprint3Task7V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] waitarray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((5*x + 2.5 / Math.Sin(x) - 2) + 2, 2);
                if (x == 0)
                {
                    waitarray[count] = 0;
                    
                }
                else 
                    waitarray[count] = y;
                count++;
            }
            return waitarray;
        }
    }
}
