using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Tyuiu.MartysevichAD.Sprint6.Task4.V1.Lib;

namespace Tyuiu.MartysevichAD.Sprint6.Task4.V1
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        
        public FormMain()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxDataIn_MAD_Enter(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonDo_MAD_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_MAD.Text);
                int stop = Convert.ToInt32(textBoxStop_MAD.Text);
                int len = ds.GetMassFunction(start, stop).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(start, stop);

                this.chartFunc_MAD.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunc_MAD.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOut_MAD.Text = "";

                chartFunc_MAD.Series[0].Points.Clear();
                for(int i = 0; i <= len -1; i++)
                {
                    this.chartFunc_MAD.Series[0].Points.AddXY(start, stop);
                    textBoxOut_MAD.AppendText(valueArray[i] + Environment.NewLine);
                    this.chartFunc_MAD.Series[0].Points.AddXY(start, valueArray[i]);
                    start++;

                }    
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_MAD_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Таск 4 выполнил студент группы ИИПб 23-3 Мартысевич А.Д.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chartFunc_MAD_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_MAD_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxOut_MAD.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно!\n Открыть его в блокноте?","Сщщбщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult ==DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }

            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
