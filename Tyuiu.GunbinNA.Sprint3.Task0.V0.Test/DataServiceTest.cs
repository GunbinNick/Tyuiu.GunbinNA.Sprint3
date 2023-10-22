using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint3.Task0.V0.Lib;

namespace Tyuiu.GunbinNA.Sprint3.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startvalue = 1;
            int stopvalue = 10;
            var res = ds.GetSumSeries(startvalue, stopvalue);
            double wait = 77.704;
            Assert.AreEqual(wait, res);

        }
    }
}
