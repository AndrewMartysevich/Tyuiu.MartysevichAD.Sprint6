
namespace Tyuiu.MartysevichAD.Sprint6.Task0.V26
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
            this.textBoxOne_MAD = new System.Windows.Forms.TextBox();
            this.pictureBoxOne_MAD = new System.Windows.Forms.PictureBox();
            this.groupBoxVvod_MAD = new System.Windows.Forms.GroupBox();
            this.groupBoxVivod_MAD = new System.Windows.Forms.GroupBox();
            this.textBoxTwo_Mad = new System.Windows.Forms.TextBox();
            this.textBoxThree_MAD = new System.Windows.Forms.TextBox();
            this.textBoxFive_MAD = new System.Windows.Forms.TextBox();
            this.textBoxFour_MAD = new System.Windows.Forms.TextBox();
            this.buttonOne_MAD = new System.Windows.Forms.Button();
            this.buttonTwo_MAD = new System.Windows.Forms.Button();
            this.groupBoxUslovie_MAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOne_MAD)).BeginInit();
            this.groupBoxVvod_MAD.SuspendLayout();
            this.groupBoxVivod_MAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_MAD
            // 
            this.groupBoxUslovie_MAD.Controls.Add(this.pictureBoxOne_MAD);
            this.groupBoxUslovie_MAD.Controls.Add(this.textBoxOne_MAD);
            this.groupBoxUslovie_MAD.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUslovie_MAD.Name = "groupBoxUslovie_MAD";
            this.groupBoxUslovie_MAD.Size = new System.Drawing.Size(578, 167);
            this.groupBoxUslovie_MAD.TabIndex = 0;
            this.groupBoxUslovie_MAD.TabStop = false;
            this.groupBoxUslovie_MAD.Text = "Условие";
            // 
            // textBoxOne_MAD
            // 
            this.textBoxOne_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOne_MAD.Location = new System.Drawing.Point(6, 21);
            this.textBoxOne_MAD.Name = "textBoxOne_MAD";
            this.textBoxOne_MAD.ReadOnly = true;
            this.textBoxOne_MAD.Size = new System.Drawing.Size(271, 15);
            this.textBoxOne_MAD.TabIndex = 0;
            this.textBoxOne_MAD.Text = "Вычислить выражение по формуле";
            this.textBoxOne_MAD.TextChanged += new System.EventHandler(this.textBoxOne_MAD_TextChanged);
            // 
            // pictureBoxOne_MAD
            // 
            this.pictureBoxOne_MAD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxOne_MAD.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOne_MAD.Image")));
            this.pictureBoxOne_MAD.InitialImage = null;
            this.pictureBoxOne_MAD.Location = new System.Drawing.Point(400, 21);
            this.pictureBoxOne_MAD.Name = "pictureBoxOne_MAD";
            this.pictureBoxOne_MAD.Size = new System.Drawing.Size(148, 87);
            this.pictureBoxOne_MAD.TabIndex = 1;
            this.pictureBoxOne_MAD.TabStop = false;
            this.pictureBoxOne_MAD.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBoxVvod_MAD
            // 
            this.groupBoxVvod_MAD.Controls.Add(this.textBoxFour_MAD);
            this.groupBoxVvod_MAD.Controls.Add(this.textBoxTwo_Mad);
            this.groupBoxVvod_MAD.Location = new System.Drawing.Point(12, 202);
            this.groupBoxVvod_MAD.Name = "groupBoxVvod_MAD";
            this.groupBoxVvod_MAD.Size = new System.Drawing.Size(281, 100);
            this.groupBoxVvod_MAD.TabIndex = 1;
            this.groupBoxVvod_MAD.TabStop = false;
            this.groupBoxVvod_MAD.Text = "Ввод Данных:";
            // 
            // groupBoxVivod_MAD
            // 
            this.groupBoxVivod_MAD.Controls.Add(this.textBoxFive_MAD);
            this.groupBoxVivod_MAD.Controls.Add(this.textBoxThree_MAD);
            this.groupBoxVivod_MAD.Location = new System.Drawing.Point(311, 202);
            this.groupBoxVivod_MAD.Name = "groupBoxVivod_MAD";
            this.groupBoxVivod_MAD.Size = new System.Drawing.Size(279, 100);
            this.groupBoxVivod_MAD.TabIndex = 2;
            this.groupBoxVivod_MAD.TabStop = false;
            this.groupBoxVivod_MAD.Text = "Вывод Данных:";
            this.groupBoxVivod_MAD.Enter += new System.EventHandler(this.groupBoxVivod_MAD_Enter);
            // 
            // textBoxTwo_Mad
            // 
            this.textBoxTwo_Mad.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTwo_Mad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTwo_Mad.Location = new System.Drawing.Point(6, 33);
            this.textBoxTwo_Mad.Name = "textBoxTwo_Mad";
            this.textBoxTwo_Mad.ReadOnly = true;
            this.textBoxTwo_Mad.Size = new System.Drawing.Size(100, 15);
            this.textBoxTwo_Mad.TabIndex = 0;
            this.textBoxTwo_Mad.Text = "Переменная X:";
            // 
            // textBoxThree_MAD
            // 
            this.textBoxThree_MAD.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxThree_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxThree_MAD.Location = new System.Drawing.Point(6, 33);
            this.textBoxThree_MAD.Name = "textBoxThree_MAD";
            this.textBoxThree_MAD.ReadOnly = true;
            this.textBoxThree_MAD.Size = new System.Drawing.Size(100, 15);
            this.textBoxThree_MAD.TabIndex = 0;
            this.textBoxThree_MAD.Text = "Результат :";
            // 
            // textBoxFive_MAD
            // 
            this.textBoxFive_MAD.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxFive_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFive_MAD.Location = new System.Drawing.Point(6, 64);
            this.textBoxFive_MAD.Name = "textBoxFive_MAD";
            this.textBoxFive_MAD.ReadOnly = true;
            this.textBoxFive_MAD.Size = new System.Drawing.Size(100, 15);
            this.textBoxFive_MAD.TabIndex = 0;
            // 
            // textBoxFour_MAD
            // 
            this.textBoxFour_MAD.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxFour_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFour_MAD.Location = new System.Drawing.Point(6, 64);
            this.textBoxFour_MAD.Name = "textBoxFour_MAD";
            this.textBoxFour_MAD.Size = new System.Drawing.Size(100, 15);
            this.textBoxFour_MAD.TabIndex = 0;
            this.textBoxFour_MAD.TextChanged += new System.EventHandler(this.textBoxFour_MAD_TextChanged);
            this.textBoxFour_MAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFour_MAD_KeyPress);
            // 
            // buttonOne_MAD
            // 
            this.buttonOne_MAD.Location = new System.Drawing.Point(455, 308);
            this.buttonOne_MAD.Name = "buttonOne_MAD";
            this.buttonOne_MAD.Size = new System.Drawing.Size(135, 41);
            this.buttonOne_MAD.TabIndex = 3;
            this.buttonOne_MAD.Text = "Выполнить";
            this.buttonOne_MAD.UseVisualStyleBackColor = true;
            this.buttonOne_MAD.Click += new System.EventHandler(this.buttonOne_MAD_Click);
            // 
            // buttonTwo_MAD
            // 
            this.buttonTwo_MAD.Location = new System.Drawing.Point(388, 309);
            this.buttonTwo_MAD.Name = "buttonTwo_MAD";
            this.buttonTwo_MAD.Size = new System.Drawing.Size(47, 40);
            this.buttonTwo_MAD.TabIndex = 4;
            this.buttonTwo_MAD.Text = "?";
            this.buttonTwo_MAD.UseVisualStyleBackColor = true;
            this.buttonTwo_MAD.Click += new System.EventHandler(this.buttonTwo_MAD_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 361);
            this.Controls.Add(this.buttonTwo_MAD);
            this.Controls.Add(this.buttonOne_MAD);
            this.Controls.Add(this.groupBoxVivod_MAD);
            this.Controls.Add(this.groupBoxVvod_MAD);
            this.Controls.Add(this.groupBoxUslovie_MAD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск0 | Вариант 26 | Мартысевич А.Д.";
            this.groupBoxUslovie_MAD.ResumeLayout(false);
            this.groupBoxUslovie_MAD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOne_MAD)).EndInit();
            this.groupBoxVvod_MAD.ResumeLayout(false);
            this.groupBoxVvod_MAD.PerformLayout();
            this.groupBoxVivod_MAD.ResumeLayout(false);
            this.groupBoxVivod_MAD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_MAD;
        private System.Windows.Forms.PictureBox pictureBoxOne_MAD;
        private System.Windows.Forms.TextBox textBoxOne_MAD;
        private System.Windows.Forms.GroupBox groupBoxVvod_MAD;
        private System.Windows.Forms.TextBox textBoxFour_MAD;
        private System.Windows.Forms.TextBox textBoxTwo_Mad;
        private System.Windows.Forms.GroupBox groupBoxVivod_MAD;
        private System.Windows.Forms.TextBox textBoxFive_MAD;
        private System.Windows.Forms.TextBox textBoxThree_MAD;
        private System.Windows.Forms.Button buttonOne_MAD;
        private System.Windows.Forms.Button buttonTwo_MAD;
    }
}

