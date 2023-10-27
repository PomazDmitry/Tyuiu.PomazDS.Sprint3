using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint3.Task5.V30.Lib;

namespace Tyuiu.PomazDS.Sprint3.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 11;
            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1,stopValue2);

            Assert.AreEqual(132, result);
        }
    }
}
