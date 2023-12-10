using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MartysevichAD.Sprint6.Task7.V16.Lib
{
    public class DataService : ISprint6Task7V16
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);

            fileData = fileData.Replace('\n', '\r');

            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            int xRow = 5;

            for(int i = 0;i<rows;i++)
            {
                string[] line_r = lines[i].Split(';');
                for(int j = 0;j<columns;j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }


            for(int r = 0; r<=xRow;r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if(arrayValues[5,c]%2!=0)
                    {
                        arrayValues[5, c] = -1;
                    }
                } 
            }
            return arrayValues;
        }
    }
}
