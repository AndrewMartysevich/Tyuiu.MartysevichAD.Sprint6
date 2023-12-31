﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MartysevichAD.Sprint6.Task1.V14.Lib
{
    public class DataService : ISprint6Task1V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double z = (Math.Cos(x) + x);
                y = Math.Round((2*x+6)/z + 3, 2);
                valueArray[count] = y;
                count++;
                if (Math.Cos(x) + x == 0)
                {
                    throw new ArgumentException($"На ноль делить нельзя");

                }
                z = 0;
            }
            return valueArray;
        }
    }
}
