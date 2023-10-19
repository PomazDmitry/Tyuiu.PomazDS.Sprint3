using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint3.Task2.V15.Lib;

namespace Tyuiu.PomazDS.Sprint3.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double a = 0.5;
            int startValue = 1;
            int stopValue = 20;
            double result = ds.GetSumSeries(a, startValue, stopValue);

            Assert.AreEqual(0.298, result);
        }
    }
}
