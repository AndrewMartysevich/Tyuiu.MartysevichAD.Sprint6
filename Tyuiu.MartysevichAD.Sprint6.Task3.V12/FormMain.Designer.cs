
namespace Tyuiu.MartysevichAD.Sprint6.Task3.V12
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
            this.groupBoxIn_MAD = new System.Windows.Forms.GroupBox();
            this.dataGridViewMtrx_MAD = new System.Windows.Forms.DataGridView();
            this.textBoxIn_MAD = new System.Windows.Forms.TextBox();
            this.groupBoxRes_MAD = new System.Windows.Forms.GroupBox();
            this.buttonInfo_MAD = new System.Windows.Forms.Button();
            this.buttonDone_MAD = new System.Windows.Forms.Button();
            this.dataGridViewOut_MAD = new System.Windows.Forms.DataGridView();
            this.groupBoxIn_MAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMtrx_MAD)).BeginInit();
            this.groupBoxRes_MAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_MAD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxIn_MAD
            // 
            this.groupBoxIn_MAD.Controls.Add(this.textBoxIn_MAD);
            this.groupBoxIn_MAD.Controls.Add(this.dataGridViewMtrx_MAD);
            this.groupBoxIn_MAD.Location = new System.Drawing.Point(12, 12);
            this.groupBoxIn_MAD.Name = "groupBoxIn_MAD";
            this.groupBoxIn_MAD.Size = new System.Drawing.Size(500, 305);
            this.groupBoxIn_MAD.TabIndex = 0;
            this.groupBoxIn_MAD.TabStop = false;
            this.groupBoxIn_MAD.Text = "Условие";
            // 
            // dataGridViewMtrx_MAD
            // 
            this.dataGridViewMtrx_MAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMtrx_MAD.Location = new System.Drawing.Point(254, 21);
            this.dataGridViewMtrx_MAD.Name = "dataGridViewMtrx_MAD";
            this.dataGridViewMtrx_MAD.ReadOnly = true;
            this.dataGridViewMtrx_MAD.RowHeadersVisible = false;
            this.dataGridViewMtrx_MAD.RowHeadersWidth = 51;
            this.dataGridViewMtrx_MAD.RowTemplate.Height = 24;
            this.dataGridViewMtrx_MAD.Size = new System.Drawing.Size(240, 226);
            this.dataGridViewMtrx_MAD.TabIndex = 0;
            // 
            // textBoxIn_MAD
            // 
            this.textBoxIn_MAD.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxIn_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIn_MAD.Location = new System.Drawing.Point(6, 21);
            this.textBoxIn_MAD.Multiline = true;
            this.textBoxIn_MAD.Name = "textBoxIn_MAD";
            this.textBoxIn_MAD.ReadOnly = true;
            this.textBoxIn_MAD.Size = new System.Drawing.Size(215, 226);
            this.textBoxIn_MAD.TabIndex = 1;
            this.textBoxIn_MAD.Text = "Дана матрица 5 на 5\r\n\r\n-6 -13  -1  -7  10\r\n\r\n 14 -18  18   1  11\r\n\r\n -2 -17 -15 -" +
    "10  -8\r\n\r\n 19  -4  -6 -11   8\r\n\r\n -17  17  14  13  19\r\n\r\nЗаменить четные значени" +
    "я в первой строке на 0.";
            // 
            // groupBoxRes_MAD
            // 
            this.groupBoxRes_MAD.Controls.Add(this.dataGridViewOut_MAD);
            this.groupBoxRes_MAD.Location = new System.Drawing.Point(518, 12);
            this.groupBoxRes_MAD.Name = "groupBoxRes_MAD";
            this.groupBoxRes_MAD.Size = new System.Drawing.Size(362, 263);
            this.groupBoxRes_MAD.TabIndex = 1;
            this.groupBoxRes_MAD.TabStop = false;
            this.groupBoxRes_MAD.Text = "Результат";
            // 
            // buttonInfo_MAD
            // 
            this.buttonInfo_MAD.Location = new System.Drawing.Point(687, 281);
            this.buttonInfo_MAD.Name = "buttonInfo_MAD";
            this.buttonInfo_MAD.Size = new System.Drawing.Size(40, 36);
            this.buttonInfo_MAD.TabIndex = 2;
            this.buttonInfo_MAD.Text = "?";
            this.buttonInfo_MAD.UseVisualStyleBackColor = true;
            this.buttonInfo_MAD.Click += new System.EventHandler(this.buttonInfo_MAD_Click);
            // 
            // buttonDone_MAD
            // 
            this.buttonDone_MAD.Location = new System.Drawing.Point(776, 281);
            this.buttonDone_MAD.Name = "buttonDone_MAD";
            this.buttonDone_MAD.Size = new System.Drawing.Size(104, 36);
            this.buttonDone_MAD.TabIndex = 2;
            this.buttonDone_MAD.Text = "Выполнить";
            this.buttonDone_MAD.UseVisualStyleBackColor = true;
            this.buttonDone_MAD.Click += new System.EventHandler(this.buttonDone_MAD_Click);
            // 
            // dataGridViewOut_MAD
            // 
            this.dataGridViewOut_MAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_MAD.Location = new System.Drawing.Point(88, 21);
            this.dataGridViewOut_MAD.Name = "dataGridViewOut_MAD";
            this.dataGridViewOut_MAD.ReadOnly = true;
            this.dataGridViewOut_MAD.RowHeadersVisible = false;
            this.dataGridViewOut_MAD.RowHeadersWidth = 51;
            this.dataGridViewOut_MAD.RowTemplate.Height = 24;
            this.dataGridViewOut_MAD.Size = new System.Drawing.Size(240, 226);
            this.dataGridViewOut_MAD.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 346);
            this.Controls.Add(this.buttonDone_MAD);
            this.Controls.Add(this.buttonInfo_MAD);
            this.Controls.Add(this.groupBoxRes_MAD);
            this.Controls.Add(this.groupBoxIn_MAD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxIn_MAD.ResumeLayout(false);
            this.groupBoxIn_MAD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMtrx_MAD)).EndInit();
            this.groupBoxRes_MAD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_MAD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIn_MAD;
        private System.Windows.Forms.TextBox textBoxIn_MAD;
        private System.Windows.Forms.DataGridView dataGridViewMtrx_MAD;
        private System.Windows.Forms.GroupBox groupBoxRes_MAD;
        private System.Windows.Forms.Button buttonInfo_MAD;
        private System.Windows.Forms.Button buttonDone_MAD;
        private System.Windows.Forms.DataGridView dataGridViewOut_MAD;
    }
}

