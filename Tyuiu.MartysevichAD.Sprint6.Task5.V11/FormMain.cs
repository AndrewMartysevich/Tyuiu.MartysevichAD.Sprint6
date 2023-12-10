using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.MartysevichAD.Sprint6.Task5.V11.Lib;

namespace Tyuiu.MartysevichAD.Sprint6.Task5.V11
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutFileTask5V11.txt";
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonDo_MAD_Click(object sender, EventArgs e)
        {
            dataGridViewZnach_MAD.ColumnCount = 2;
            dataGridViewZnach_MAD.Columns[0].Width = 20;
            dataGridViewZnach_MAD.Columns[1].Width = 50;

            this.chartGist_MAD.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartGist_MAD.ChartAreas[0].AxisY.Title = "Ось Y";

            chartGist_MAD.Series[0].Points.Clear();

            double[] nums = new double[ds.len];
            nums = ds.LoadFromDataFile(path);

            for(int i = 0; i < nums.Length;i++)
            {
                dataGridViewZnach_MAD.Rows.Add(Convert.ToString(i), Convert.ToString(nums[i]));
                chartGist_MAD.Series[0].Points.AddXY(i, nums[i]);
            }
        }

        private void buttonFile_MAD_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_MAD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб 23-3 Мартысевич А.Д.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}
