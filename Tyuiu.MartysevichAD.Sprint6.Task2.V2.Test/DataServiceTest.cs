using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MartysevichAD.Sprint6.Task2.V2.Lib;

namespace Tyuiu.MartysevichAD.Sprint6.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;
            double[] ValueWaitArray;
            ValueWaitArray = new double[len];
            ValueWaitArray[0] = 6.49;
            ValueWaitArray[1] = -9.88;
            ValueWaitArray[2] = -12.26;
            ValueWaitArray[3] = -4.60;
            ValueWaitArray[4] = 0.52;
            ValueWaitArray[5] = 4;
            ValueWaitArray[6] = -0.75;
            ValueWaitArray[7] = 4.55;
            ValueWaitArray[8] = 12.23;
            ValueWaitArray[9] = 9.86;
            ValueWaitArray[10] = -6.50;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(ValueWaitArray, res);
        }
    }
}
