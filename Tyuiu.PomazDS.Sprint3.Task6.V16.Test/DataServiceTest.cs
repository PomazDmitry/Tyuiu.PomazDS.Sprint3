using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint3.Task6.V16.Lib;

namespace Tyuiu.PomazDS.Sprint3.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 5;
            int stopValue = 16;
            int result = ds.GetSumTheDivisors(startValue, stopValue);

            Assert.AreEqual(42, result);
        }
    }
}
