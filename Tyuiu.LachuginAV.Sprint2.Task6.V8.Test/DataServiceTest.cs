using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.LachuginAV.Sprint2.Task6.V8.Lib;

namespace Tyuiu.LachuginAV.Sprint2.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            int m = 2, n = 2;
            Assert.AreEqual("Дата предыдущего дня: " + 1 + "." + 2, ds.FindDateOfPreviousDay(m, n));

        }
    }
}