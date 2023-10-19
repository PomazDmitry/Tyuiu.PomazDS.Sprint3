using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint3.Task3.V9.Lib;

namespace Tyuiu.PomazDS.Sprint3.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();

            char item = 'w';
            string value = "56hy vfe4r4 vf45b";
            string result = ds.ReplaceNumOnChar(value,item);

            Assert.AreEqual("wwhy vfewrw vfwwb", result);
        }
    }
}
