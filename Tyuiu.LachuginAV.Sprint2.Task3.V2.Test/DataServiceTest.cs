using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LachuginAV.Sprint2.Task3.V2.Lib;

namespace Tyuiu.LachuginAV.Sprint2.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 0; double y = -0.577;
            Assert.AreEqual(y, ds.Calculate(x));
        }
    }
}