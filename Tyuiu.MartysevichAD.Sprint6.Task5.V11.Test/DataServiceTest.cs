using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MartysevichAD.Sprint6.Task5.V11.Lib;

namespace Tyuiu.MartysevichAD.Sprint6.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask5V11.txt";
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = new double[1];
            wait[0] = 10;
            CollectionAssert.AreEqual(wait, res);

        }
    }
}
