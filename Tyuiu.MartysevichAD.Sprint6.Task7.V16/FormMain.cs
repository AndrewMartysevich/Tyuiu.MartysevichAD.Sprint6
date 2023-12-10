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
using Tyuiu.MartysevichAD.Sprint6.Task7.V16.Lib;

namespace Tyuiu.MartysevichAD.Sprint6.Task7.V16
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_MAD.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_MAD.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');

            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

             rows = lines.Length;
             columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];


            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }
        private void panelTop_MAD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_MAD.ColumnCount = 50;
            dataGridViewOut_MAD.ColumnCount = 50;

            dataGridViewIn_MAD.RowCount = 50;
            dataGridViewOut_MAD.RowCount = 50;

            panelLeft_MAD.Width = this.Width / 2;

            for(int i =0;i<50;i++)
            {
                dataGridViewIn_MAD.Columns[i].Width = 25;
                dataGridViewOut_MAD.Columns[i].Width = 25;
            }
        }

        private void buttonDown_MAD_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MAD.ShowDialog();
            openFilePath = openFileDialogTask_MAD.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_MAD.ColumnCount = columns;
            dataGridViewIn_MAD.RowCount = rows;
            dataGridViewOut_MAD.ColumnCount = columns;
            dataGridViewOut_MAD.RowCount = rows;

            for(int i = 0; i<columns;i++)
            {
                dataGridViewIn_MAD.Columns[i].Width = 25;
                dataGridViewOut_MAD.Columns[i].Width = 25;
            }

            for(int r = 0; r< rows;r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_MAD.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDo_MAD.Enabled = true;
        }

        private void buttonDo_MAD_Click(object sender, EventArgs e)
        {
            int[,] Value = new int[rows, columns];
             Value = ds.GetMatrix(openFilePath);

            for(int r =0;r<rows;r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_MAD.Rows[r].Cells[c].Value = Value[r, c];
                }
            }

            buttonSave_MAD.Enabled = true;
        
        }

        private void buttonSave_MAD_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_MAD.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_MAD.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_MAD.ShowDialog();

            string path = saveFileDialogMatrix_MAD.FileName;

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;

            if(fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_MAD.RowCount;
            int columns = dataGridViewOut_MAD.ColumnCount;

            string str = "";

            for(int i =0;i<rows;i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if(j!=columns-1)
                    {
                        str += dataGridViewOut_MAD.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOut_MAD.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonInfo_MAD_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDown_MAD_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_MAD.ToolTipTitle = "Открыть файл";
        }

        private void buttonDo_MAD_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_MAD.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_MAD_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_MAD.ToolTipTitle = "Сохранить";
        }

        private void buttonInfo_MAD_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_MAD.ToolTipTitle = "Справка";
        }
    }
}
