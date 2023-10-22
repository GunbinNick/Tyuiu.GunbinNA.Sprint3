using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint3.Task2.V27.Lib;

namespace Tyuiu.GunbinNA.Sprint3.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 5;
            int startvalue = 1;
            int stopvalue = 14;
            var res = ds.GetSumSeries(value, startvalue, stopvalue);
            double wait = 2.71137311507644E+45;
            Assert.AreEqual(wait, res);
        }
    }
}
