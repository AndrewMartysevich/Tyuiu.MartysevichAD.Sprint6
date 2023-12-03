using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MartysevichAD.Sprint6.Task0.V26.Lib;

namespace Tyuiu.MartysevichAD.Sprint6.Task0.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxVivod_MAD_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxOne_MAD_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOne_MAD_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxFive_MAD.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxFour_MAD.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTwo_MAD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПб 23-3 Мартысевич Андрей Денисович");
        }

        private void textBoxFour_MAD_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFour_MAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
