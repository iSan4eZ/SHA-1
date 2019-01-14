namespace SHA_1
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartLab = new System.Windows.Forms.Button();
            this.btnTheory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHashIt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartLab
            // 
            this.btnStartLab.Location = new System.Drawing.Point(31, 12);
            this.btnStartLab.Name = "btnStartLab";
            this.btnStartLab.Size = new System.Drawing.Size(173, 23);
            this.btnStartLab.TabIndex = 0;
            this.btnStartLab.Text = "Начать лабораторную работу";
            this.btnStartLab.UseVisualStyleBackColor = true;
            this.btnStartLab.Click += new System.EventHandler(this.btnStartLab_Click);
            // 
            // btnTheory
            // 
            this.btnTheory.Location = new System.Drawing.Point(76, 41);
            this.btnTheory.Name = "btnTheory";
            this.btnTheory.Size = new System.Drawing.Size(75, 23);
            this.btnTheory.TabIndex = 1;
            this.btnTheory.Text = "Теория";
            this.btnTheory.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Станислав Панасюк\r\nАнастасия Тычинская\r\nЮлия Высоцкая\r\nОльга Малецкая\r\n ИА-61, 20" +
    "18";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHashIt
            // 
            this.btnHashIt.Location = new System.Drawing.Point(2, 34);
            this.btnHashIt.Name = "btnHashIt";
            this.btnHashIt.Size = new System.Drawing.Size(68, 36);
            this.btnHashIt.TabIndex = 3;
            this.btnHashIt.Text = "Хешировать текст";
            this.btnHashIt.UseVisualStyleBackColor = true;
            this.btnHashIt.Click += new System.EventHandler(this.btnHashIt_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 137);
            this.Controls.Add(this.btnHashIt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTheory);
            this.Controls.Add(this.btnStartLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartLab;
        private System.Windows.Forms.Button btnTheory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHashIt;
    }
}

