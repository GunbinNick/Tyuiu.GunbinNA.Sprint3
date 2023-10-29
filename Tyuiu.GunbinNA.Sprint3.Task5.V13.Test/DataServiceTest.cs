using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint3.Task5.V13.Lib;

namespace Tyuiu.GunbinNA.Sprint3.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start1 = 1;
            int end1 = 3;
            int start2 = 1;
            int end2 = 12;
            int x = 5;

            var res = ds.GetSumSumSeries(x, start1, end1, start2, end2);
            Assert.AreEqual(236.424, res);
        }
    }
}
