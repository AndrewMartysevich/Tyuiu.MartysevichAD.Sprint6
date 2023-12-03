using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MartysevichAD.Sprint6.Task3.V12.Lib;

namespace Tyuiu.MartysevichAD.Sprint6.Task3.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonInfo_MAD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб 23-3 Мартысевич А.Д.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        DataService ds = new DataService();
        int[,] matrix = { { -6, -13, -1, -7, 10 }, { 14, -18, 18, 1, 11 }, { -2, -17, -15, -10, -8 }, { 19, -4, -6, -11, 8 }, { -17, 17, 14, 13, 19 } };
        private void buttonDone_MAD_Click(object sender, EventArgs e)
        {
            int[,] mtrx = ds.Calculate(matrix);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows ;

            dataGridViewOut_MAD.ColumnCount = columns;
            dataGridViewOut_MAD.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                dataGridViewOut_MAD.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOut_MAD.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
        

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewMtrx_MAD.ColumnCount = columns;
            dataGridViewMtrx_MAD.RowCount = rows;

            for (int i = 0; i<rows;i++)
            {
                dataGridViewMtrx_MAD.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMtrx_MAD.Rows[i].Cells[j].Value = Convert.ToString(matrix[i,j]);
                }
            }
        }
    }
}
