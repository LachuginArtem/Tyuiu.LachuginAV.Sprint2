using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.LachuginAV.Sprint2.Task5.V9.Lib;

namespace Tyuiu.LachuginAV.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();

            int m = 1, n = 1;
            Assert.AreEqual("Дата следующего дня: " + 2 +"."+ 1, ds.FindDateOfNextDay(m, n));

        }
    }
}