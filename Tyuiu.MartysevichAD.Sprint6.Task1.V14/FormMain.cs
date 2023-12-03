using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MartysevichAD.Sprint6.Task1.V14.Lib;

namespace Tyuiu.MartysevichAD.Sprint6.Task1.V14
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }
        
        private void buttonDo_MAD_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxY_MAD.Text);
                int stop = Convert.ToInt32(textBoxX_MAD.Text);
                string strLine;

                int len = ds.GetMassFunction(start, stop).Length;
                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(start, stop);
                textBoxResult_MAD.Text = "";
                textBoxResult_MAD.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_MAD.AppendText("|     X    |   F(X)   |" + Environment.NewLine);
                textBoxResult_MAD.AppendText("+----------+----------+" + Environment.NewLine);

                for(int i = 0; i<=len-1;i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}   |",start,valueArray[i]);
                    textBoxResult_MAD.AppendText(strLine + Environment.NewLine);
                    start++;
                }

                textBoxResult_MAD.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_MAD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб 23-3 Мартысевич А.Д.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
