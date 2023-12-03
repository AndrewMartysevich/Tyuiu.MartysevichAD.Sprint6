
namespace Tyuiu.MartysevichAD.Sprint6.Task1.V14
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
            this.groupBoxUslovie_MAD = new System.Windows.Forms.GroupBox();
            this.pictureBoxIn_MAD = new System.Windows.Forms.PictureBox();
            this.groupBoxResult_MAD = new System.Windows.Forms.GroupBox();
            this.textBoxResult_MAD = new System.Windows.Forms.TextBox();
            this.TextBoxOut_MAD = new System.Windows.Forms.TextBox();
            this.groupBoxData_MAD = new System.Windows.Forms.GroupBox();
            this.textBoxstop_MAD = new System.Windows.Forms.TextBox();
            this.textBoxStart_MAD = new System.Windows.Forms.TextBox();
            this.textBoxY_MAD = new System.Windows.Forms.TextBox();
            this.textBoxX_MAD = new System.Windows.Forms.TextBox();
            this.buttonInfo_MAD = new System.Windows.Forms.Button();
            this.buttonDo_MAD = new System.Windows.Forms.Button();
            this.groupBoxUslovie_MAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIn_MAD)).BeginInit();
            this.groupBoxResult_MAD.SuspendLayout();
            this.groupBoxData_MAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_MAD
            // 
            this.groupBoxUslovie_MAD.Controls.Add(this.pictureBoxIn_MAD);
            this.groupBoxUslovie_MAD.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUslovie_MAD.Name = "groupBoxUslovie_MAD";
            this.groupBoxUslovie_MAD.Size = new System.Drawing.Size(852, 300);
            this.groupBoxUslovie_MAD.TabIndex = 0;
            this.groupBoxUslovie_MAD.TabStop = false;
            this.groupBoxUslovie_MAD.Text = "Условие";
            // 
            // pictureBoxIn_MAD
            // 
            this.pictureBoxIn_MAD.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIn_MAD.Image")));
            this.pictureBoxIn_MAD.Location = new System.Drawing.Point(6, 21);
            this.pictureBoxIn_MAD.Name = "pictureBoxIn_MAD";
            this.pictureBoxIn_MAD.Size = new System.Drawing.Size(840, 250);
            this.pictureBoxIn_MAD.TabIndex = 0;
            this.pictureBoxIn_MAD.TabStop = false;
            // 
            // groupBoxResult_MAD
            // 
            this.groupBoxResult_MAD.Controls.Add(this.textBoxResult_MAD);
            this.groupBoxResult_MAD.Controls.Add(this.TextBoxOut_MAD);
            this.groupBoxResult_MAD.Location = new System.Drawing.Point(870, 12);
            this.groupBoxResult_MAD.Name = "groupBoxResult_MAD";
            this.groupBoxResult_MAD.Size = new System.Drawing.Size(283, 406);
            this.groupBoxResult_MAD.TabIndex = 1;
            this.groupBoxResult_MAD.TabStop = false;
            this.groupBoxResult_MAD.Text = "Вывод Данных";
            // 
            // textBoxResult_MAD
            // 
            this.textBoxResult_MAD.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxResult_MAD.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_MAD.Location = new System.Drawing.Point(6, 42);
            this.textBoxResult_MAD.Multiline = true;
            this.textBoxResult_MAD.Name = "textBoxResult_MAD";
            this.textBoxResult_MAD.ReadOnly = true;
            this.textBoxResult_MAD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_MAD.Size = new System.Drawing.Size(271, 358);
            this.textBoxResult_MAD.TabIndex = 1;
            // 
            // TextBoxOut_MAD
            // 
            this.TextBoxOut_MAD.BackColor = System.Drawing.SystemColors.Menu;
            this.TextBoxOut_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxOut_MAD.Location = new System.Drawing.Point(6, 21);
            this.TextBoxOut_MAD.Name = "TextBoxOut_MAD";
            this.TextBoxOut_MAD.ReadOnly = true;
            this.TextBoxOut_MAD.Size = new System.Drawing.Size(100, 15);
            this.TextBoxOut_MAD.TabIndex = 0;
            this.TextBoxOut_MAD.Text = "Результат:";
            // 
            // groupBoxData_MAD
            // 
            this.groupBoxData_MAD.Controls.Add(this.textBoxstop_MAD);
            this.groupBoxData_MAD.Controls.Add(this.textBoxStart_MAD);
            this.groupBoxData_MAD.Controls.Add(this.textBoxY_MAD);
            this.groupBoxData_MAD.Controls.Add(this.textBoxX_MAD);
            this.groupBoxData_MAD.Location = new System.Drawing.Point(12, 318);
            this.groupBoxData_MAD.Name = "groupBoxData_MAD";
            this.groupBoxData_MAD.Size = new System.Drawing.Size(405, 100);
            this.groupBoxData_MAD.TabIndex = 2;
            this.groupBoxData_MAD.TabStop = false;
            this.groupBoxData_MAD.Text = "Ввод Данных";
            // 
            // textBoxstop_MAD
            // 
            this.textBoxstop_MAD.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxstop_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxstop_MAD.Location = new System.Drawing.Point(189, 30);
            this.textBoxstop_MAD.Name = "textBoxstop_MAD";
            this.textBoxstop_MAD.ReadOnly = true;
            this.textBoxstop_MAD.Size = new System.Drawing.Size(100, 15);
            this.textBoxstop_MAD.TabIndex = 1;
            this.textBoxstop_MAD.Text = "Конец Шага";
            // 
            // textBoxStart_MAD
            // 
            this.textBoxStart_MAD.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxStart_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStart_MAD.Location = new System.Drawing.Point(7, 30);
            this.textBoxStart_MAD.Name = "textBoxStart_MAD";
            this.textBoxStart_MAD.ReadOnly = true;
            this.textBoxStart_MAD.Size = new System.Drawing.Size(100, 15);
            this.textBoxStart_MAD.TabIndex = 1;
            this.textBoxStart_MAD.Text = "Старт Шага";
            // 
            // textBoxY_MAD
            // 
            this.textBoxY_MAD.Location = new System.Drawing.Point(6, 58);
            this.textBoxY_MAD.Name = "textBoxY_MAD";
            this.textBoxY_MAD.Size = new System.Drawing.Size(156, 22);
            this.textBoxY_MAD.TabIndex = 0;
            // 
            // textBoxX_MAD
            // 
            this.textBoxX_MAD.Location = new System.Drawing.Point(189, 58);
            this.textBoxX_MAD.Name = "textBoxX_MAD";
            this.textBoxX_MAD.Size = new System.Drawing.Size(151, 22);
            this.textBoxX_MAD.TabIndex = 0;
            // 
            // buttonInfo_MAD
            // 
            this.buttonInfo_MAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonInfo_MAD.Location = new System.Drawing.Point(476, 318);
            this.buttonInfo_MAD.Name = "buttonInfo_MAD";
            this.buttonInfo_MAD.Size = new System.Drawing.Size(168, 100);
            this.buttonInfo_MAD.TabIndex = 3;
            this.buttonInfo_MAD.Text = "Справка";
            this.buttonInfo_MAD.UseVisualStyleBackColor = false;
            this.buttonInfo_MAD.Click += new System.EventHandler(this.buttonInfo_MAD_Click);
            // 
            // buttonDo_MAD
            // 
            this.buttonDo_MAD.BackColor = System.Drawing.Color.Aqua;
            this.buttonDo_MAD.Location = new System.Drawing.Point(699, 318);
            this.buttonDo_MAD.Name = "buttonDo_MAD";
            this.buttonDo_MAD.Size = new System.Drawing.Size(165, 100);
            this.buttonDo_MAD.TabIndex = 3;
            this.buttonDo_MAD.Text = "Выполнить";
            this.buttonDo_MAD.UseVisualStyleBackColor = false;
            this.buttonDo_MAD.Click += new System.EventHandler(this.buttonDo_MAD_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 430);
            this.Controls.Add(this.buttonDo_MAD);
            this.Controls.Add(this.buttonInfo_MAD);
            this.Controls.Add(this.groupBoxData_MAD);
            this.Controls.Add(this.groupBoxResult_MAD);
            this.Controls.Add(this.groupBoxUslovie_MAD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск1 | Вариант 14 | Мартысевич А.Д.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxUslovie_MAD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIn_MAD)).EndInit();
            this.groupBoxResult_MAD.ResumeLayout(false);
            this.groupBoxResult_MAD.PerformLayout();
            this.groupBoxData_MAD.ResumeLayout(false);
            this.groupBoxData_MAD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_MAD;
        private System.Windows.Forms.PictureBox pictureBoxIn_MAD;
        private System.Windows.Forms.GroupBox groupBoxResult_MAD;
        private System.Windows.Forms.TextBox textBoxResult_MAD;
        private System.Windows.Forms.TextBox TextBoxOut_MAD;
        private System.Windows.Forms.GroupBox groupBoxData_MAD;
        private System.Windows.Forms.TextBox textBoxstop_MAD;
        private System.Windows.Forms.TextBox textBoxStart_MAD;
        private System.Windows.Forms.TextBox textBoxY_MAD;
        private System.Windows.Forms.TextBox textBoxX_MAD;
        private System.Windows.Forms.Button buttonInfo_MAD;
        private System.Windows.Forms.Button buttonDo_MAD;
    }
}

