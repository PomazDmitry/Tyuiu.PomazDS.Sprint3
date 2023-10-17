using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint3.Task0.V18.Lib;

namespace Tyuiu.PomazDS.Sprint3.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int value = 1;
            int startValue = 1;
            int stopValue = 6;
            double result = ds.GetMultiplySeries(value,startValue, stopValue);
            double wait = 914700.94;
            Assert.AreEqual(wait,result);
            
        }
    }
}
