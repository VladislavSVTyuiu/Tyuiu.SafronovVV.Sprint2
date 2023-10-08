using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SafronovVV.Sprint2.Task4.V8.Lib;

namespace Tyuiu.SafronovVV.Sprint2.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = -1.5;

            Assert.AreEqual(wait, res);
        }
    }
}
