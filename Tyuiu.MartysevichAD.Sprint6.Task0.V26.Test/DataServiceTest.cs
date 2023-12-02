using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MartysevichAD.Sprint6.Task0.V26.Lib;

namespace Tyuiu.MartysevichAD.Sprint6.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            double wait = 0.769;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait,res);
        }
    }
}
