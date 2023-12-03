using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MartysevichAD.Sprint6.Task2.V2.Lib;

namespace Tyuiu.MartysevichAD.Sprint6.Task2.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxStopValue_MAD_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonInfo_MAD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб 23-3 Мартысевич А.Д.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonResult_MAD_MouseEnter(object sender, EventArgs e)
        {
            buttonResult_MAD.BackColor = Color.Red;
        }

        private void buttonResult_MAD_MouseLeave(object sender, EventArgs e)
        {
            buttonResult_MAD.BackColor = Color.Green;
        }

        private void buttonResult_MAD_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResult_MAD.BackColor = Color.Blue;
        }
        DataService ds = new DataService();
        private void buttonResult_MAD_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStartValue_MAD.Text);
                int stop = Convert.ToInt32(textBoxStopValue_MAD.Text);

                int len = ds.GetMassFunction(start, stop).Length;
                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(start, stop);

                this.chartFunc_MAD.Titles.Add("График функции");
                this.chartFunc_MAD.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunc_MAD.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunc_MAD.Rows.Add(Convert.ToString(start), Convert.ToString(valueArray[i]));
                    this.chartFunc_MAD.Series[0].Points.AddXY(start, valueArray[i]);
                    start++;
                }

             
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
