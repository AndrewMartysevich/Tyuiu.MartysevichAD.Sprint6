
namespace Tyuiu.MartysevichAD.Sprint6.Task7.V16
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop_MAD = new System.Windows.Forms.Panel();
            this.panelTopTwo_MAD = new System.Windows.Forms.Panel();
            this.panelLeft_MAD = new System.Windows.Forms.Panel();
            this.panelFill_MAD = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBoxIn_MAD = new System.Windows.Forms.GroupBox();
            this.groupBoxDataIN_MAD = new System.Windows.Forms.GroupBox();
            this.groupBoxDataOut_MAD = new System.Windows.Forms.GroupBox();
            this.textBoxIn_MAD = new System.Windows.Forms.TextBox();
            this.buttonDown_MAD = new System.Windows.Forms.Button();
            this.buttonDo_MAD = new System.Windows.Forms.Button();
            this.buttonSave_MAD = new System.Windows.Forms.Button();
            this.buttonInfo_MAD = new System.Windows.Forms.Button();
            this.dataGridViewIn_MAD = new System.Windows.Forms.DataGridView();
            this.dataGridViewOut_MAD = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_MAD = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_MAD = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_MAD = new System.Windows.Forms.SaveFileDialog();
            this.panelTop_MAD.SuspendLayout();
            this.panelTopTwo_MAD.SuspendLayout();
            this.panelLeft_MAD.SuspendLayout();
            this.panelFill_MAD.SuspendLayout();
            this.groupBoxIn_MAD.SuspendLayout();
            this.groupBoxDataIN_MAD.SuspendLayout();
            this.groupBoxDataOut_MAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_MAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_MAD)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_MAD
            // 
            this.panelTop_MAD.Controls.Add(this.buttonInfo_MAD);
            this.panelTop_MAD.Controls.Add(this.buttonSave_MAD);
            this.panelTop_MAD.Controls.Add(this.buttonDo_MAD);
            this.panelTop_MAD.Controls.Add(this.buttonDown_MAD);
            this.panelTop_MAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_MAD.Location = new System.Drawing.Point(0, 0);
            this.panelTop_MAD.Name = "panelTop_MAD";
            this.panelTop_MAD.Size = new System.Drawing.Size(960, 76);
            this.panelTop_MAD.TabIndex = 0;
            this.panelTop_MAD.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_MAD_Paint);
            // 
            // panelTopTwo_MAD
            // 
            this.panelTopTwo_MAD.Controls.Add(this.groupBoxIn_MAD);
            this.panelTopTwo_MAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopTwo_MAD.Location = new System.Drawing.Point(0, 76);
            this.panelTopTwo_MAD.Name = "panelTopTwo_MAD";
            this.panelTopTwo_MAD.Size = new System.Drawing.Size(960, 75);
            this.panelTopTwo_MAD.TabIndex = 1;
            // 
            // panelLeft_MAD
            // 
            this.panelLeft_MAD.Controls.Add(this.groupBoxDataIN_MAD);
            this.panelLeft_MAD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_MAD.Location = new System.Drawing.Point(0, 151);
            this.panelLeft_MAD.Name = "panelLeft_MAD";
            this.panelLeft_MAD.Size = new System.Drawing.Size(481, 404);
            this.panelLeft_MAD.TabIndex = 2;
            // 
            // panelFill_MAD
            // 
            this.panelFill_MAD.Controls.Add(this.groupBoxDataOut_MAD);
            this.panelFill_MAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_MAD.Location = new System.Drawing.Point(481, 151);
            this.panelFill_MAD.Name = "panelFill_MAD";
            this.panelFill_MAD.Size = new System.Drawing.Size(479, 404);
            this.panelFill_MAD.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(481, 151);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 404);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // groupBoxIn_MAD
            // 
            this.groupBoxIn_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxIn_MAD.Controls.Add(this.textBoxIn_MAD);
            this.groupBoxIn_MAD.Location = new System.Drawing.Point(13, 7);
            this.groupBoxIn_MAD.Name = "groupBoxIn_MAD";
            this.groupBoxIn_MAD.Size = new System.Drawing.Size(935, 62);
            this.groupBoxIn_MAD.TabIndex = 0;
            this.groupBoxIn_MAD.TabStop = false;
            this.groupBoxIn_MAD.Text = "Условие";
            // 
            // groupBoxDataIN_MAD
            // 
            this.groupBoxDataIN_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDataIN_MAD.Controls.Add(this.dataGridViewIn_MAD);
            this.groupBoxDataIN_MAD.Location = new System.Drawing.Point(13, 7);
            this.groupBoxDataIN_MAD.Name = "groupBoxDataIN_MAD";
            this.groupBoxDataIN_MAD.Size = new System.Drawing.Size(462, 385);
            this.groupBoxDataIN_MAD.TabIndex = 0;
            this.groupBoxDataIN_MAD.TabStop = false;
            this.groupBoxDataIN_MAD.Text = "Ввод";
            // 
            // groupBoxDataOut_MAD
            // 
            this.groupBoxDataOut_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDataOut_MAD.Controls.Add(this.dataGridViewOut_MAD);
            this.groupBoxDataOut_MAD.Location = new System.Drawing.Point(17, 7);
            this.groupBoxDataOut_MAD.Name = "groupBoxDataOut_MAD";
            this.groupBoxDataOut_MAD.Size = new System.Drawing.Size(462, 385);
            this.groupBoxDataOut_MAD.TabIndex = 0;
            this.groupBoxDataOut_MAD.TabStop = false;
            this.groupBoxDataOut_MAD.Text = "Вывод";
            // 
            // textBoxIn_MAD
            // 
            this.textBoxIn_MAD.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxIn_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIn_MAD.Location = new System.Drawing.Point(7, 22);
            this.textBoxIn_MAD.Multiline = true;
            this.textBoxIn_MAD.Name = "textBoxIn_MAD";
            this.textBoxIn_MAD.ReadOnly = true;
            this.textBoxIn_MAD.Size = new System.Drawing.Size(922, 34);
            this.textBoxIn_MAD.TabIndex = 0;
            this.textBoxIn_MAD.Text = "Дан файл InPutFileTask7V16.csv в котором хранится матрица целочисленных значений." +
    " \r\nЗагрузить файл через openFileDialog в объект dataGridViewIn. Изменить в пятой" +
    " строке нечетные значения на -1.";
            // 
            // buttonDown_MAD
            // 
            this.buttonDown_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDown_MAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDown_MAD.Image = ((System.Drawing.Image)(resources.GetObject("buttonDown_MAD.Image")));
            this.buttonDown_MAD.Location = new System.Drawing.Point(4, 3);
            this.buttonDown_MAD.Name = "buttonDown_MAD";
            this.buttonDown_MAD.Size = new System.Drawing.Size(75, 67);
            this.buttonDown_MAD.TabIndex = 0;
            this.toolTipButton_MAD.SetToolTip(this.buttonDown_MAD, "Открыть файл для обработки данных в формате csv. ");
            this.buttonDown_MAD.UseVisualStyleBackColor = false;
            this.buttonDown_MAD.Click += new System.EventHandler(this.buttonDown_MAD_Click);
            this.buttonDown_MAD.MouseEnter += new System.EventHandler(this.buttonDown_MAD_MouseEnter);
            // 
            // buttonDo_MAD
            // 
            this.buttonDo_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDo_MAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDo_MAD.Enabled = false;
            this.buttonDo_MAD.Image = ((System.Drawing.Image)(resources.GetObject("buttonDo_MAD.Image")));
            this.buttonDo_MAD.Location = new System.Drawing.Point(85, 3);
            this.buttonDo_MAD.Name = "buttonDo_MAD";
            this.buttonDo_MAD.Size = new System.Drawing.Size(75, 67);
            this.buttonDo_MAD.TabIndex = 0;
            this.toolTipButton_MAD.SetToolTip(this.buttonDo_MAD, "Выполнить обработку данных.");
            this.buttonDo_MAD.UseVisualStyleBackColor = false;
            this.buttonDo_MAD.Click += new System.EventHandler(this.buttonDo_MAD_Click);
            this.buttonDo_MAD.MouseEnter += new System.EventHandler(this.buttonDo_MAD_MouseEnter);
            // 
            // buttonSave_MAD
            // 
            this.buttonSave_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave_MAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSave_MAD.Enabled = false;
            this.buttonSave_MAD.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_MAD.Image")));
            this.buttonSave_MAD.Location = new System.Drawing.Point(166, 3);
            this.buttonSave_MAD.Name = "buttonSave_MAD";
            this.buttonSave_MAD.Size = new System.Drawing.Size(75, 67);
            this.buttonSave_MAD.TabIndex = 0;
            this.toolTipButton_MAD.SetToolTip(this.buttonSave_MAD, "Сохранить обработанные данные в файл в формате csv.");
            this.buttonSave_MAD.UseVisualStyleBackColor = false;
            this.buttonSave_MAD.Click += new System.EventHandler(this.buttonSave_MAD_Click);
            this.buttonSave_MAD.MouseEnter += new System.EventHandler(this.buttonSave_MAD_MouseEnter);
            // 
            // buttonInfo_MAD
            // 
            this.buttonInfo_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_MAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonInfo_MAD.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_MAD.Image")));
            this.buttonInfo_MAD.Location = new System.Drawing.Point(873, 6);
            this.buttonInfo_MAD.Name = "buttonInfo_MAD";
            this.buttonInfo_MAD.Size = new System.Drawing.Size(75, 67);
            this.buttonInfo_MAD.TabIndex = 0;
            this.toolTipButton_MAD.SetToolTip(this.buttonInfo_MAD, "Сведения о программе");
            this.buttonInfo_MAD.UseVisualStyleBackColor = false;
            this.buttonInfo_MAD.Click += new System.EventHandler(this.buttonInfo_MAD_Click);
            this.buttonInfo_MAD.MouseEnter += new System.EventHandler(this.buttonInfo_MAD_MouseEnter);
            // 
            // dataGridViewIn_MAD
            // 
            this.dataGridViewIn_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewIn_MAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_MAD.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewIn_MAD.Name = "dataGridViewIn_MAD";
            this.dataGridViewIn_MAD.RowHeadersWidth = 51;
            this.dataGridViewIn_MAD.RowTemplate.Height = 24;
            this.dataGridViewIn_MAD.Size = new System.Drawing.Size(449, 348);
            this.dataGridViewIn_MAD.TabIndex = 0;
            // 
            // dataGridViewOut_MAD
            // 
            this.dataGridViewOut_MAD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOut_MAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_MAD.Location = new System.Drawing.Point(6, 22);
            this.dataGridViewOut_MAD.Name = "dataGridViewOut_MAD";
            this.dataGridViewOut_MAD.RowHeadersWidth = 51;
            this.dataGridViewOut_MAD.RowTemplate.Height = 24;
            this.dataGridViewOut_MAD.Size = new System.Drawing.Size(444, 348);
            this.dataGridViewOut_MAD.TabIndex = 0;
            // 
            // openFileDialogTask_MAD
            // 
            this.openFileDialogTask_MAD.FileName = "openFileDialog1";
            // 
            // toolTipButton_MAD
            // 
            this.toolTipButton_MAD.IsBalloon = true;
            this.toolTipButton_MAD.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_MAD.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 555);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelFill_MAD);
            this.Controls.Add(this.panelLeft_MAD);
            this.Controls.Add(this.panelTopTwo_MAD);
            this.Controls.Add(this.panelTop_MAD);
            this.MinimumSize = new System.Drawing.Size(978, 602);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск7 | Вариант 16 | Мартысевич А.Д.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop_MAD.ResumeLayout(false);
            this.panelTopTwo_MAD.ResumeLayout(false);
            this.panelLeft_MAD.ResumeLayout(false);
            this.panelFill_MAD.ResumeLayout(false);
            this.groupBoxIn_MAD.ResumeLayout(false);
            this.groupBoxIn_MAD.PerformLayout();
            this.groupBoxDataIN_MAD.ResumeLayout(false);
            this.groupBoxDataOut_MAD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_MAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_MAD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_MAD;
        private System.Windows.Forms.Button buttonInfo_MAD;
        private System.Windows.Forms.Button buttonSave_MAD;
        private System.Windows.Forms.Button buttonDo_MAD;
        private System.Windows.Forms.Button buttonDown_MAD;
        private System.Windows.Forms.Panel panelTopTwo_MAD;
        private System.Windows.Forms.GroupBox groupBoxIn_MAD;
        private System.Windows.Forms.TextBox textBoxIn_MAD;
        private System.Windows.Forms.Panel panelLeft_MAD;
        private System.Windows.Forms.GroupBox groupBoxDataIN_MAD;
        private System.Windows.Forms.DataGridView dataGridViewIn_MAD;
        private System.Windows.Forms.Panel panelFill_MAD;
        private System.Windows.Forms.GroupBox groupBoxDataOut_MAD;
        private System.Windows.Forms.DataGridView dataGridViewOut_MAD;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_MAD;
        private System.Windows.Forms.ToolTip toolTipButton_MAD;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_MAD;
    }
}

