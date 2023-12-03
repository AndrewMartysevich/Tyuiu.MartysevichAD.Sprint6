
namespace Tyuiu.MartysevichAD.Sprint6.Task2.V2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxIn_MAD = new System.Windows.Forms.GroupBox();
            this.groupBoxOut_MAD = new System.Windows.Forms.GroupBox();
            this.chartFunc_MAD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunc_MAD = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxData_MAD = new System.Windows.Forms.GroupBox();
            this.textBoxStopValue_MAD = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_MAD = new System.Windows.Forms.TextBox();
            this.textBoxStop_MAD = new System.Windows.Forms.TextBox();
            this.textBoxStart_MAD = new System.Windows.Forms.TextBox();
            this.buttonInfo_MAD = new System.Windows.Forms.Button();
            this.buttonResult_MAD = new System.Windows.Forms.Button();
            this.textBoxIn_MAD = new System.Windows.Forms.TextBox();
            this.groupBoxIn_MAD.SuspendLayout();
            this.groupBoxOut_MAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_MAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunc_MAD)).BeginInit();
            this.groupBoxData_MAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIn_MAD
            // 
            this.groupBoxIn_MAD.Controls.Add(this.textBoxIn_MAD);
            this.groupBoxIn_MAD.Location = new System.Drawing.Point(12, 12);
            this.groupBoxIn_MAD.Name = "groupBoxIn_MAD";
            this.groupBoxIn_MAD.Size = new System.Drawing.Size(577, 332);
            this.groupBoxIn_MAD.TabIndex = 0;
            this.groupBoxIn_MAD.TabStop = false;
            this.groupBoxIn_MAD.Text = "Условие";
            // 
            // groupBoxOut_MAD
            // 
            this.groupBoxOut_MAD.Controls.Add(this.chartFunc_MAD);
            this.groupBoxOut_MAD.Controls.Add(this.dataGridViewFunc_MAD);
            this.groupBoxOut_MAD.Location = new System.Drawing.Point(595, 12);
            this.groupBoxOut_MAD.Name = "groupBoxOut_MAD";
            this.groupBoxOut_MAD.Size = new System.Drawing.Size(907, 455);
            this.groupBoxOut_MAD.TabIndex = 1;
            this.groupBoxOut_MAD.TabStop = false;
            this.groupBoxOut_MAD.Text = "Вывод Данных";
            // 
            // chartFunc_MAD
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunc_MAD.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunc_MAD.Legends.Add(legend1);
            this.chartFunc_MAD.Location = new System.Drawing.Point(277, 21);
            this.chartFunc_MAD.Name = "chartFunc_MAD";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunc_MAD.Series.Add(series1);
            this.chartFunc_MAD.Size = new System.Drawing.Size(582, 417);
            this.chartFunc_MAD.TabIndex = 1;
            this.chartFunc_MAD.Text = "chart1";
            // 
            // dataGridViewFunc_MAD
            // 
            this.dataGridViewFunc_MAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunc_MAD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.F});
            this.dataGridViewFunc_MAD.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewFunc_MAD.Name = "dataGridViewFunc_MAD";
            this.dataGridViewFunc_MAD.RowHeadersVisible = false;
            this.dataGridViewFunc_MAD.RowHeadersWidth = 51;
            this.dataGridViewFunc_MAD.RowTemplate.Height = 24;
            this.dataGridViewFunc_MAD.Size = new System.Drawing.Size(236, 417);
            this.dataGridViewFunc_MAD.TabIndex = 0;
            // 
            // X
            // 
            this.X.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.X.FillWeight = 90F;
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 90;
            // 
            // F
            // 
            this.F.FillWeight = 90F;
            this.F.HeaderText = "F(X)";
            this.F.MinimumWidth = 6;
            this.F.Name = "F";
            this.F.Width = 90;
            // 
            // groupBoxData_MAD
            // 
            this.groupBoxData_MAD.Controls.Add(this.textBoxStopValue_MAD);
            this.groupBoxData_MAD.Controls.Add(this.textBoxStartValue_MAD);
            this.groupBoxData_MAD.Controls.Add(this.textBoxStop_MAD);
            this.groupBoxData_MAD.Controls.Add(this.textBoxStart_MAD);
            this.groupBoxData_MAD.Location = new System.Drawing.Point(13, 350);
            this.groupBoxData_MAD.Name = "groupBoxData_MAD";
            this.groupBoxData_MAD.Size = new System.Drawing.Size(271, 77);
            this.groupBoxData_MAD.TabIndex = 2;
            this.groupBoxData_MAD.TabStop = false;
            this.groupBoxData_MAD.Text = "Ввод Данных";
            // 
            // textBoxStopValue_MAD
            // 
            this.textBoxStopValue_MAD.Location = new System.Drawing.Point(151, 42);
            this.textBoxStopValue_MAD.Name = "textBoxStopValue_MAD";
            this.textBoxStopValue_MAD.Size = new System.Drawing.Size(100, 22);
            this.textBoxStopValue_MAD.TabIndex = 1;
            this.textBoxStopValue_MAD.TextChanged += new System.EventHandler(this.textBoxStopValue_MAD_TextChanged);
            // 
            // textBoxStartValue_MAD
            // 
            this.textBoxStartValue_MAD.Location = new System.Drawing.Point(7, 43);
            this.textBoxStartValue_MAD.Name = "textBoxStartValue_MAD";
            this.textBoxStartValue_MAD.Size = new System.Drawing.Size(100, 22);
            this.textBoxStartValue_MAD.TabIndex = 1;
            // 
            // textBoxStop_MAD
            // 
            this.textBoxStop_MAD.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxStop_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStop_MAD.Location = new System.Drawing.Point(151, 21);
            this.textBoxStop_MAD.Name = "textBoxStop_MAD";
            this.textBoxStop_MAD.ReadOnly = true;
            this.textBoxStop_MAD.Size = new System.Drawing.Size(100, 15);
            this.textBoxStop_MAD.TabIndex = 0;
            this.textBoxStop_MAD.Text = "Конец Шага";
            // 
            // textBoxStart_MAD
            // 
            this.textBoxStart_MAD.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxStart_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStart_MAD.Location = new System.Drawing.Point(7, 22);
            this.textBoxStart_MAD.Name = "textBoxStart_MAD";
            this.textBoxStart_MAD.ReadOnly = true;
            this.textBoxStart_MAD.Size = new System.Drawing.Size(100, 15);
            this.textBoxStart_MAD.TabIndex = 0;
            this.textBoxStart_MAD.Text = "Старт Шага";
            // 
            // buttonInfo_MAD
            // 
            this.buttonInfo_MAD.BackColor = System.Drawing.Color.Aqua;
            this.buttonInfo_MAD.Location = new System.Drawing.Point(290, 352);
            this.buttonInfo_MAD.Name = "buttonInfo_MAD";
            this.buttonInfo_MAD.Size = new System.Drawing.Size(147, 75);
            this.buttonInfo_MAD.TabIndex = 3;
            this.buttonInfo_MAD.Text = "Справка";
            this.buttonInfo_MAD.UseVisualStyleBackColor = false;
            this.buttonInfo_MAD.Click += new System.EventHandler(this.buttonInfo_MAD_Click);
            // 
            // buttonResult_MAD
            // 
            this.buttonResult_MAD.BackColor = System.Drawing.Color.Green;
            this.buttonResult_MAD.Location = new System.Drawing.Point(443, 352);
            this.buttonResult_MAD.Name = "buttonResult_MAD";
            this.buttonResult_MAD.Size = new System.Drawing.Size(146, 75);
            this.buttonResult_MAD.TabIndex = 3;
            this.buttonResult_MAD.Text = "Выполнить";
            this.buttonResult_MAD.UseVisualStyleBackColor = false;
            this.buttonResult_MAD.Click += new System.EventHandler(this.buttonResult_MAD_Click);
            this.buttonResult_MAD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonResult_MAD_MouseDown);
            this.buttonResult_MAD.MouseEnter += new System.EventHandler(this.buttonResult_MAD_MouseEnter);
            this.buttonResult_MAD.MouseLeave += new System.EventHandler(this.buttonResult_MAD_MouseLeave);
            // 
            // textBoxIn_MAD
            // 
            this.textBoxIn_MAD.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxIn_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIn_MAD.Location = new System.Drawing.Point(8, 21);
            this.textBoxIn_MAD.Multiline = true;
            this.textBoxIn_MAD.Name = "textBoxIn_MAD";
            this.textBoxIn_MAD.ReadOnly = true;
            this.textBoxIn_MAD.Size = new System.Drawing.Size(546, 54);
            this.textBoxIn_MAD.TabIndex = 0;
            this.textBoxIn_MAD.Text = "Протабулировать функцию на заданном диапазоне\r\nРезультат вывести в DataGridView и" +
    " построить график функции\r\n\r\n";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 479);
            this.Controls.Add(this.buttonResult_MAD);
            this.Controls.Add(this.buttonInfo_MAD);
            this.Controls.Add(this.groupBoxData_MAD);
            this.Controls.Add(this.groupBoxOut_MAD);
            this.Controls.Add(this.groupBoxIn_MAD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск2 | Вариант 2 | Мартысевич А.Д.";
            this.groupBoxIn_MAD.ResumeLayout(false);
            this.groupBoxIn_MAD.PerformLayout();
            this.groupBoxOut_MAD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_MAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunc_MAD)).EndInit();
            this.groupBoxData_MAD.ResumeLayout(false);
            this.groupBoxData_MAD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIn_MAD;
        private System.Windows.Forms.GroupBox groupBoxOut_MAD;
        private System.Windows.Forms.GroupBox groupBoxData_MAD;
        private System.Windows.Forms.TextBox textBoxStopValue_MAD;
        private System.Windows.Forms.TextBox textBoxStartValue_MAD;
        private System.Windows.Forms.TextBox textBoxStop_MAD;
        private System.Windows.Forms.TextBox textBoxStart_MAD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc_MAD;
        private System.Windows.Forms.DataGridView dataGridViewFunc_MAD;
        private System.Windows.Forms.Button buttonInfo_MAD;
        private System.Windows.Forms.Button buttonResult_MAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.TextBox textBoxIn_MAD;
    }
}

