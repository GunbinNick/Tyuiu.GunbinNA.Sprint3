using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint3.Task7.V19.Lib;

namespace Tyuiu.GunbinNA.Sprint3.Task7.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;

            int len = end - start + 1;
            double[] waitarray;
            waitarray = new double[len];
            waitarray[0] = -22.39;
            waitarray[1] = -16.7;
            waitarray[2] = -32.72;
            waitarray[3] = -12.75;
            waitarray[4] = -7.97;
            waitarray[5] = 0;
            waitarray[6] = 7.97;
            waitarray[7] = 12.75;
            waitarray[8] = 32.72;
            waitarray[9] = 16.7;
            waitarray[10] = 22.39;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, end);
            CollectionAssert.AreEqual(waitarray, res);



        }
    }
}
