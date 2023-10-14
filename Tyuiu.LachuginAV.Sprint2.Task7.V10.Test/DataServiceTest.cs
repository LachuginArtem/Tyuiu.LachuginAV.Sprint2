
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LachuginAV.Sprint2.Task7.V10.Lib;

namespace Tyuiu.LachuginAV.Sprint2.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            Assert.AreEqual(false, ds.CheckDotInShadedArea(0.5, 0.5));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(0, 1));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(-0.5, -0.5));
        }
    }
}
