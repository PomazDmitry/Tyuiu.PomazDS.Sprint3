using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint3.Task7.V18.Lib;

namespace Tyuiu.PomazDS.Sprint3.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            double[] array = new double[stopValue - startValue + 1];

            array[0] = 7.76;
            array[1] = 7.36;
            array[2] = 7.26;
            array[3] = 7.9;
            array[4] = 15.88;
            array[5] = 0;
            array[6] = 4.35;
            array[7] = 5.63;
            array[8] = 6.49;
            array[9] = 6.49;
            array[10] = 6.32;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(array, result);
        }
    }
}
