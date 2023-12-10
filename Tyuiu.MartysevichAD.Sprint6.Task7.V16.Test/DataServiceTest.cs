﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MartysevichAD.Sprint6.Task7.V16.Lib;

namespace Tyuiu.MartysevichAD.Sprint6.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask7V16.csv";
            int[,] res = ds.GetMatrix(path);
            int[,] wait = { { 16, 14, 13, -5, 17, -18, 19, 1, 2, 10 },
                            { -19, 4, -20, -5, -5, 19, -7, -13, 15, 3 } , 
                            { 16, 4, 4, -16, -9, 12, 8, 1, 6, -15 } ,
                            { -1, -19, -18, 1, 8, 14, -11, 15, -15, -1},
                            {8, -15, 3, -4, 12, 18, 19, -1, -14, -2 },
                            { 2, -14, 2, -1, -1, -16, -14, -1, -1, -1},
                            {-5, -9, -13, 12, 11, -6, -7, -2, -16, -12 },
                            {-2, -9, -15, -13, 5, -12, 2, -8, -16, -13 } ,
                            {-19, -2, -9, 0, 13, 19, -2, 5, -1, -18 } ,
                            {-5, 3, 8, 19, -19, 15, 4, -12, 20, 15 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
