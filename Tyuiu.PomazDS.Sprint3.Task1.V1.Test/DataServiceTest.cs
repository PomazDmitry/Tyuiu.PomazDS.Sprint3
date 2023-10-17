using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Policy;

using Tyuiu.PomazDS.Sprint3.Task1.V1.Lib;

namespace Tyuiu.PomazDS.Sprint3.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int endValue = 7;
            double res = ds.GetMultiplySeries(startValue, endValue);
            Assert.AreEqual(5.311, res);
        }
    }
}
