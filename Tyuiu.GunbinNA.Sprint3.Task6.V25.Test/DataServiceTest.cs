using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint3.Task6.V25.Lib;
namespace Tyuiu.GunbinNA.Sprint3.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = 16;
            int end = 24;
            var res = ds.GetSumTheDivisors(start, end);
            Assert.AreEqual(89, res);
        }
    }
}
