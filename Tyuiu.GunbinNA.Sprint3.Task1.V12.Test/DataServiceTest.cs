using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint3.Task1.V12.Lib;

namespace Tyuiu.GunbinNA.Sprint3.Task1.V12.Test
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
            int stopvalue = 10;
            var res = ds.GetSumSeries(value, startvalue, stopvalue);
            double wait = 1.001;
            Assert.AreEqual(wait, res);
        }
    }
}
