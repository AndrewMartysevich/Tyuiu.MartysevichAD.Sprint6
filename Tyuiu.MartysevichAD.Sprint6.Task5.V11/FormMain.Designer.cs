
namespace Tyuiu.MartysevichAD.Sprint6.Task5.V11
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_MAD = new System.Windows.Forms.Panel();
            this.panelLeft_MAD = new System.Windows.Forms.Panel();
            this.panelFill_MAD = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBoxTop_MAD = new System.Windows.Forms.GroupBox();
            this.groupBoxDone_MAD = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewZnach_MAD = new System.Windows.Forms.DataGridView();
            this.buttonDo_MAD = new System.Windows.Forms.Button();
            this.buttonFile_MAD = new System.Windows.Forms.Button();
            this.buttonInfo_MAD = new System.Windows.Forms.Button();
            this.chartGist_MAD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_MAD.SuspendLayout();
            this.panelLeft_MAD.SuspendLayout();
            this.panelFill_MAD.SuspendLayout();
            this.groupBoxTop_MAD.SuspendLayout();
            this.groupBoxDone_MAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZnach_MAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGist_MAD)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_MAD
            // 
            this.panelTop_MAD.Controls.Add(this.buttonInfo_MAD);
            this.panelTop_MAD.Controls.Add(this.buttonFile_MAD);
            this.panelTop_MAD.Controls.Add(this.buttonDo_MAD);
            this.panelTop_MAD.Controls.Add(this.groupBoxTop_MAD);
            this.panelTop_MAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_MAD.Location = new System.Drawing.Point(0, 0);
            this.panelTop_MAD.Name = "panelTop_MAD";
            this.panelTop_MAD.Size = new System.Drawing.Size(917, 100);
            this.panelTop_MAD.TabIndex = 0;
            // 
            // panelLeft_MAD
            // 
            this.panelLeft_MAD.Controls.Add(this.groupBoxDone_MAD);
            this.panelLeft_MAD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_MAD.Location = new System.Drawing.Point(0, 100);
            this.panelLeft_MAD.Name = "panelLeft_MAD";
            this.panelLeft_MAD.Size = new System.Drawing.Size(200, 463);
            this.panelLeft_MAD.TabIndex = 1;
            // 
            // panelFill_MAD
            // 
            this.panelFill_MAD.Controls.Add(this.chartGist_MAD);
            this.panelFill_MAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_MAD.Location = new System.Drawing.Point(200, 100);
            this.panelFill_MAD.Name = "panelFill_MAD";
            this.panelFill_MAD.Size = new System.Drawing.Size(717, 463);
            this.panelFill_MAD.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 100);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 463);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // groupBoxTop_MAD
            // 
            this.groupBoxTop_MAD.Controls.Add(this.textBox1);
            this.groupBoxTop_MAD.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTop_MAD.Name = "groupBoxTop_MAD";
            this.groupBoxTop_MAD.Size = new System.Drawing.Size(534, 81);
            this.groupBoxTop_MAD.TabIndex = 0;
            this.groupBoxTop_MAD.TabStop = false;
            this.groupBoxTop_MAD.Text = "Условие";
            // 
            // groupBoxDone_MAD
            // 
            this.groupBoxDone_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDone_MAD.Controls.Add(this.dataGridViewZnach_MAD);
            this.groupBoxDone_MAD.Location = new System.Drawing.Point(13, 7);
            this.groupBoxDone_MAD.Name = "groupBoxDone_MAD";
            this.groupBoxDone_MAD.Size = new System.Drawing.Size(181, 467);
            this.groupBoxDone_MAD.TabIndex = 0;
            this.groupBoxDone_MAD.TabStop = false;
            this.groupBoxDone_MAD.Text = "Вывод";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(7, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(518, 53);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Прочитать данные из файла InPutFileTask5V11.txt. Вывести в dataGridView. Дан спис" +
    "ок из чисел. Вывести все числа, кратные 5. Построить диаграмму по этим значениям" +
    ".\r\n";
            // 
            // dataGridViewZnach_MAD
            // 
            this.dataGridViewZnach_MAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZnach_MAD.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewZnach_MAD.Name = "dataGridViewZnach_MAD";
            this.dataGridViewZnach_MAD.RowHeadersWidth = 51;
            this.dataGridViewZnach_MAD.RowTemplate.Height = 24;
            this.dataGridViewZnach_MAD.Size = new System.Drawing.Size(168, 423);
            this.dataGridViewZnach_MAD.TabIndex = 0;
            // 
            // buttonDo_MAD
            // 
            this.buttonDo_MAD.BackColor = System.Drawing.Color.Yellow;
            this.buttonDo_MAD.Location = new System.Drawing.Point(587, 13);
            this.buttonDo_MAD.Name = "buttonDo_MAD";
            this.buttonDo_MAD.Size = new System.Drawing.Size(90, 75);
            this.buttonDo_MAD.TabIndex = 1;
            this.buttonDo_MAD.Text = "Выполнить";
            this.buttonDo_MAD.UseVisualStyleBackColor = false;
            this.buttonDo_MAD.Click += new System.EventHandler(this.buttonDo_MAD_Click);
            // 
            // buttonFile_MAD
            // 
            this.buttonFile_MAD.BackColor = System.Drawing.Color.Cyan;
            this.buttonFile_MAD.Location = new System.Drawing.Point(698, 12);
            this.buttonFile_MAD.Name = "buttonFile_MAD";
            this.buttonFile_MAD.Size = new System.Drawing.Size(89, 75);
            this.buttonFile_MAD.TabIndex = 1;
            this.buttonFile_MAD.Text = "Открыть\r\nфайл";
            this.buttonFile_MAD.UseVisualStyleBackColor = false;
            this.buttonFile_MAD.Click += new System.EventHandler(this.buttonFile_MAD_Click);
            // 
            // buttonInfo_MAD
            // 
            this.buttonInfo_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_MAD.BackColor = System.Drawing.Color.Lime;
            this.buttonInfo_MAD.Location = new System.Drawing.Point(812, 12);
            this.buttonInfo_MAD.Name = "buttonInfo_MAD";
            this.buttonInfo_MAD.Size = new System.Drawing.Size(93, 75);
            this.buttonInfo_MAD.TabIndex = 1;
            this.buttonInfo_MAD.Text = "Справка";
            this.buttonInfo_MAD.UseVisualStyleBackColor = false;
            this.buttonInfo_MAD.Click += new System.EventHandler(this.buttonInfo_MAD_Click);
            // 
            // chartGist_MAD
            // 
            this.chartGist_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.Name = "ChartArea1";
            this.chartGist_MAD.ChartAreas.Add(chartArea6);
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.chartGist_MAD.Legends.Add(legend6);
            this.chartGist_MAD.Location = new System.Drawing.Point(10, 7);
            this.chartGist_MAD.Name = "chartGist_MAD";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartGist_MAD.Series.Add(series6);
            this.chartGist_MAD.Size = new System.Drawing.Size(695, 444);
            this.chartGist_MAD.TabIndex = 0;
            this.chartGist_MAD.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 563);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelFill_MAD);
            this.Controls.Add(this.panelLeft_MAD);
            this.Controls.Add(this.panelTop_MAD);
            this.MinimumSize = new System.Drawing.Size(935, 610);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск5 | Вариант 11 | Мартысевич А.Д.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop_MAD.ResumeLayout(false);
            this.panelLeft_MAD.ResumeLayout(false);
            this.panelFill_MAD.ResumeLayout(false);
            this.groupBoxTop_MAD.ResumeLayout(false);
            this.groupBoxTop_MAD.PerformLayout();
            this.groupBoxDone_MAD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZnach_MAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGist_MAD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_MAD;
        private System.Windows.Forms.Button buttonInfo_MAD;
        private System.Windows.Forms.Button buttonFile_MAD;
        private System.Windows.Forms.Button buttonDo_MAD;
        private System.Windows.Forms.GroupBox groupBoxTop_MAD;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelLeft_MAD;
        private System.Windows.Forms.GroupBox groupBoxDone_MAD;
        private System.Windows.Forms.DataGridView dataGridViewZnach_MAD;
        private System.Windows.Forms.Panel panelFill_MAD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGist_MAD;
        private System.Windows.Forms.Splitter splitter1;
    }
}

