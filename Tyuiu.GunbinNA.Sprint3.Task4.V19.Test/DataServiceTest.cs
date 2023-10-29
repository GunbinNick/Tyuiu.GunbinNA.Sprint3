using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint3.Task4.V19.Lib;
namespace Tyuiu.GunbinNA.Sprint3.Task4.V19.Test
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
            var res = ds.Calculate(start, end);
            Assert.AreEqual(9.432, res);
        }
    }
}
