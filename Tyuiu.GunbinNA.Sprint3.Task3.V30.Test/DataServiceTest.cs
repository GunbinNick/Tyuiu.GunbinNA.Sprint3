using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GunbinNA.Sprint3.Task3.V30.Lib;

namespace Tyuiu.GunbinNA.Sprint3.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "fyyklbtyn ygrc vfyyyyh";
            char chr = 'y';

            var res = ds.GetMaxCharCount(str, chr);

            int wait = 8;
            Assert.AreEqual(wait, res);
        }
    }
}
