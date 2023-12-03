using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MartysevichAD.Sprint6.Task1.V14.Lib;

namespace Tyuiu.MartysevichAD.Sprint6.Task1.V14.Test
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
            ValueWaitArray[0] = 3.85;
            ValueWaitArray[1] = 3.43;
            ValueWaitArray[2] = 3.00;
            ValueWaitArray[3] = 2.17;
            ValueWaitArray[4] = -5.70;
            ValueWaitArray[5] = 9;
            ValueWaitArray[6] = 8.19;
            ValueWaitArray[7] = 9.31;
            ValueWaitArray[8] = 8.97;
            ValueWaitArray[9] = 7.18;
            ValueWaitArray[10] = 6.03;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(ValueWaitArray, res);
        }
    }
}
