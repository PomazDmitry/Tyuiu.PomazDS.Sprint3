using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint3.Task4.V13.Lib;

namespace Tyuiu.PomazDS.Sprint3.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double result = ds.Calculate(startValue, stopValue);

            Assert.AreEqual(1.899,result);
        }
    }
}
