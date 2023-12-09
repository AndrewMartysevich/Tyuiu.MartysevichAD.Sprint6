
namespace Tyuiu.MartysevichAD.Sprint6.Task4.V1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelOne_MAD = new System.Windows.Forms.Panel();
            this.panelTwo_MAD = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelBig_MAD = new System.Windows.Forms.Panel();
            this.groupBoxDataIn_MAD = new System.Windows.Forms.GroupBox();
            this.groupBoxIn_MAD = new System.Windows.Forms.GroupBox();
            this.textBoxOne_MAD = new System.Windows.Forms.TextBox();
            this.textBoxVvod_MAD = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_MAD = new System.Windows.Forms.TextBox();
            this.textBoxViv_MAD = new System.Windows.Forms.TextBox();
            this.textBoxVvodEnd_MAD = new System.Windows.Forms.TextBox();
            this.textBoxStart_MAD = new System.Windows.Forms.TextBox();
            this.textBoxStop_MAD = new System.Windows.Forms.TextBox();
            this.buttonDo_MAD = new System.Windows.Forms.Button();
            this.buttonSave_MAD = new System.Windows.Forms.Button();
            this.buttonInfo_MAD = new System.Windows.Forms.Button();
            this.chartFunc_MAD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxOut_MAD = new System.Windows.Forms.TextBox();
            this.panelOne_MAD.SuspendLayout();
            this.panelTwo_MAD.SuspendLayout();
            this.panelBig_MAD.SuspendLayout();
            this.groupBoxDataIn_MAD.SuspendLayout();
            this.groupBoxIn_MAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_MAD)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOne_MAD
            // 
            this.panelOne_MAD.Controls.Add(this.buttonInfo_MAD);
            this.panelOne_MAD.Controls.Add(this.buttonSave_MAD);
            this.panelOne_MAD.Controls.Add(this.buttonDo_MAD);
            this.panelOne_MAD.Controls.Add(this.groupBoxIn_MAD);
            this.panelOne_MAD.Controls.Add(this.groupBoxDataIn_MAD);
            this.panelOne_MAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOne_MAD.Location = new System.Drawing.Point(0, 0);
            this.panelOne_MAD.Name = "panelOne_MAD";
            this.panelOne_MAD.Size = new System.Drawing.Size(1088, 133);
            this.panelOne_MAD.TabIndex = 0;
            // 
            // panelTwo_MAD
            // 
            this.panelTwo_MAD.Controls.Add(this.textBoxOut_MAD);
            this.panelTwo_MAD.Controls.Add(this.textBoxViv_MAD);
            this.panelTwo_MAD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTwo_MAD.Location = new System.Drawing.Point(0, 133);
            this.panelTwo_MAD.Name = "panelTwo_MAD";
            this.panelTwo_MAD.Size = new System.Drawing.Size(362, 443);
            this.panelTwo_MAD.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(338, 246);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(362, 133);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 443);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // panelBig_MAD
            // 
            this.panelBig_MAD.Controls.Add(this.chartFunc_MAD);
            this.panelBig_MAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBig_MAD.Location = new System.Drawing.Point(365, 133);
            this.panelBig_MAD.Name = "panelBig_MAD";
            this.panelBig_MAD.Size = new System.Drawing.Size(723, 443);
            this.panelBig_MAD.TabIndex = 4;
            // 
            // groupBoxDataIn_MAD
            // 
            this.groupBoxDataIn_MAD.Controls.Add(this.textBoxStop_MAD);
            this.groupBoxDataIn_MAD.Controls.Add(this.textBoxStart_MAD);
            this.groupBoxDataIn_MAD.Controls.Add(this.textBoxVvodEnd_MAD);
            this.groupBoxDataIn_MAD.Controls.Add(this.textBoxStartStep_MAD);
            this.groupBoxDataIn_MAD.Controls.Add(this.textBoxVvod_MAD);
            this.groupBoxDataIn_MAD.Location = new System.Drawing.Point(425, 12);
            this.groupBoxDataIn_MAD.Name = "groupBoxDataIn_MAD";
            this.groupBoxDataIn_MAD.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxDataIn_MAD.Size = new System.Drawing.Size(304, 109);
            this.groupBoxDataIn_MAD.TabIndex = 0;
            this.groupBoxDataIn_MAD.TabStop = false;
            this.groupBoxDataIn_MAD.Text = "Ввод Данных:";
            this.groupBoxDataIn_MAD.Enter += new System.EventHandler(this.groupBoxDataIn_MAD_Enter);
            // 
            // groupBoxIn_MAD
            // 
            this.groupBoxIn_MAD.Controls.Add(this.textBoxOne_MAD);
            this.groupBoxIn_MAD.Location = new System.Drawing.Point(12, 12);
            this.groupBoxIn_MAD.Name = "groupBoxIn_MAD";
            this.groupBoxIn_MAD.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxIn_MAD.Size = new System.Drawing.Size(407, 109);
            this.groupBoxIn_MAD.TabIndex = 0;
            this.groupBoxIn_MAD.TabStop = false;
            this.groupBoxIn_MAD.Text = "Условие";
            this.groupBoxIn_MAD.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBoxOne_MAD
            // 
            this.textBoxOne_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOne_MAD.Location = new System.Drawing.Point(9, 24);
            this.textBoxOne_MAD.Multiline = true;
            this.textBoxOne_MAD.Name = "textBoxOne_MAD";
            this.textBoxOne_MAD.ReadOnly = true;
            this.textBoxOne_MAD.Size = new System.Drawing.Size(390, 77);
            this.textBoxOne_MAD.TabIndex = 0;
            this.textBoxOne_MAD.Text = resources.GetString("textBoxOne_MAD.Text");
            // 
            // textBoxVvod_MAD
            // 
            this.textBoxVvod_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVvod_MAD.Location = new System.Drawing.Point(8, 24);
            this.textBoxVvod_MAD.Name = "textBoxVvod_MAD";
            this.textBoxVvod_MAD.ReadOnly = true;
            this.textBoxVvod_MAD.Size = new System.Drawing.Size(100, 15);
            this.textBoxVvod_MAD.TabIndex = 0;
            // 
            // textBoxStartStep_MAD
            // 
            this.textBoxStartStep_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStartStep_MAD.Location = new System.Drawing.Point(8, 24);
            this.textBoxStartStep_MAD.Name = "textBoxStartStep_MAD";
            this.textBoxStartStep_MAD.ReadOnly = true;
            this.textBoxStartStep_MAD.Size = new System.Drawing.Size(100, 15);
            this.textBoxStartStep_MAD.TabIndex = 0;
            this.textBoxStartStep_MAD.Text = "Старт Шага:";
            // 
            // textBoxViv_MAD
            // 
            this.textBoxViv_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxViv_MAD.Location = new System.Drawing.Point(21, 5);
            this.textBoxViv_MAD.Name = "textBoxViv_MAD";
            this.textBoxViv_MAD.ReadOnly = true;
            this.textBoxViv_MAD.Size = new System.Drawing.Size(100, 15);
            this.textBoxViv_MAD.TabIndex = 0;
            this.textBoxViv_MAD.Text = "Вывод:";
            // 
            // textBoxVvodEnd_MAD
            // 
            this.textBoxVvodEnd_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVvodEnd_MAD.Location = new System.Drawing.Point(192, 24);
            this.textBoxVvodEnd_MAD.Name = "textBoxVvodEnd_MAD";
            this.textBoxVvodEnd_MAD.ReadOnly = true;
            this.textBoxVvodEnd_MAD.Size = new System.Drawing.Size(100, 15);
            this.textBoxVvodEnd_MAD.TabIndex = 1;
            this.textBoxVvodEnd_MAD.Text = "Конец Шага:";
            // 
            // textBoxStart_MAD
            // 
            this.textBoxStart_MAD.Location = new System.Drawing.Point(8, 59);
            this.textBoxStart_MAD.Name = "textBoxStart_MAD";
            this.textBoxStart_MAD.Size = new System.Drawing.Size(100, 22);
            this.textBoxStart_MAD.TabIndex = 2;
            // 
            // textBoxStop_MAD
            // 
            this.textBoxStop_MAD.Location = new System.Drawing.Point(192, 59);
            this.textBoxStop_MAD.Name = "textBoxStop_MAD";
            this.textBoxStop_MAD.Size = new System.Drawing.Size(100, 22);
            this.textBoxStop_MAD.TabIndex = 2;
            // 
            // buttonDo_MAD
            // 
            this.buttonDo_MAD.BackColor = System.Drawing.Color.Lime;
            this.buttonDo_MAD.Location = new System.Drawing.Point(751, 32);
            this.buttonDo_MAD.Name = "buttonDo_MAD";
            this.buttonDo_MAD.Size = new System.Drawing.Size(90, 81);
            this.buttonDo_MAD.TabIndex = 1;
            this.buttonDo_MAD.Text = "Выполнить";
            this.buttonDo_MAD.UseVisualStyleBackColor = false;
            this.buttonDo_MAD.Click += new System.EventHandler(this.buttonDo_MAD_Click);
            // 
            // buttonSave_MAD
            // 
            this.buttonSave_MAD.BackColor = System.Drawing.Color.Aqua;
            this.buttonSave_MAD.Location = new System.Drawing.Point(847, 32);
            this.buttonSave_MAD.Name = "buttonSave_MAD";
            this.buttonSave_MAD.Size = new System.Drawing.Size(90, 81);
            this.buttonSave_MAD.TabIndex = 1;
            this.buttonSave_MAD.Text = "Сохранить";
            this.buttonSave_MAD.UseVisualStyleBackColor = false;
            this.buttonSave_MAD.Click += new System.EventHandler(this.buttonSave_MAD_Click);
            // 
            // buttonInfo_MAD
            // 
            this.buttonInfo_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_MAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonInfo_MAD.Location = new System.Drawing.Point(986, 32);
            this.buttonInfo_MAD.Name = "buttonInfo_MAD";
            this.buttonInfo_MAD.Size = new System.Drawing.Size(90, 81);
            this.buttonInfo_MAD.TabIndex = 1;
            this.buttonInfo_MAD.Text = "Справка";
            this.buttonInfo_MAD.UseVisualStyleBackColor = false;
            this.buttonInfo_MAD.Click += new System.EventHandler(this.buttonInfo_MAD_Click);
            // 
            // chartFunc_MAD
            // 
            this.chartFunc_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartFunc_MAD.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartFunc_MAD.Legends.Add(legend2);
            this.chartFunc_MAD.Location = new System.Drawing.Point(6, 6);
            this.chartFunc_MAD.Name = "chartFunc_MAD";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunc_MAD.Series.Add(series2);
            this.chartFunc_MAD.Size = new System.Drawing.Size(705, 425);
            this.chartFunc_MAD.TabIndex = 0;
            this.chartFunc_MAD.Text = "chart1";
            title2.Name = "Titlefunc";
            title2.Text = "ГРАФИК ФУНКЦИИ";
            this.chartFunc_MAD.Titles.Add(title2);
            this.chartFunc_MAD.Click += new System.EventHandler(this.chartFunc_MAD_Click);
            // 
            // textBoxOut_MAD
            // 
            this.textBoxOut_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOut_MAD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxOut_MAD.Location = new System.Drawing.Point(13, 26);
            this.textBoxOut_MAD.Multiline = true;
            this.textBoxOut_MAD.Name = "textBoxOut_MAD";
            this.textBoxOut_MAD.ReadOnly = true;
            this.textBoxOut_MAD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut_MAD.Size = new System.Drawing.Size(319, 405);
            this.textBoxOut_MAD.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 576);
            this.Controls.Add(this.panelBig_MAD);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelTwo_MAD);
            this.Controls.Add(this.panelOne_MAD);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1106, 623);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск4 | Вариант 1 | Мартысевич А.Д.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelOne_MAD.ResumeLayout(false);
            this.panelTwo_MAD.ResumeLayout(false);
            this.panelTwo_MAD.PerformLayout();
            this.panelBig_MAD.ResumeLayout(false);
            this.groupBoxDataIn_MAD.ResumeLayout(false);
            this.groupBoxDataIn_MAD.PerformLayout();
            this.groupBoxIn_MAD.ResumeLayout(false);
            this.groupBoxIn_MAD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_MAD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOne_MAD;
        private System.Windows.Forms.Panel panelTwo_MAD;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelBig_MAD;
        private System.Windows.Forms.GroupBox groupBoxIn_MAD;
        private System.Windows.Forms.GroupBox groupBoxDataIn_MAD;
        private System.Windows.Forms.TextBox textBoxOne_MAD;
        private System.Windows.Forms.Button buttonInfo_MAD;
        private System.Windows.Forms.Button buttonSave_MAD;
        private System.Windows.Forms.Button buttonDo_MAD;
        private System.Windows.Forms.TextBox textBoxStop_MAD;
        private System.Windows.Forms.TextBox textBoxStart_MAD;
        private System.Windows.Forms.TextBox textBoxVvodEnd_MAD;
        private System.Windows.Forms.TextBox textBoxViv_MAD;
        private System.Windows.Forms.TextBox textBoxStartStep_MAD;
        private System.Windows.Forms.TextBox textBoxVvod_MAD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc_MAD;
        private System.Windows.Forms.TextBox textBoxOut_MAD;
    }
}

