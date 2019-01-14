namespace SHA_1
{
    partial class StepThree
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.lblH0 = new System.Windows.Forms.Label();
            this.lblH1 = new System.Windows.Forms.Label();
            this.lblH2 = new System.Windows.Forms.Label();
            this.lblH3 = new System.Windows.Forms.Label();
            this.lblH4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Итак, мы имеем итоговые значения после всех вычислений. \r\nКаков конеченый результ" +
    "ат?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "h0 =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "h1 =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "h2 =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "h3 =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "h4 =";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(285, 168);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 12;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(12, 140);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(348, 20);
            this.txbResult.TabIndex = 13;
            // 
            // lblH0
            // 
            this.lblH0.AutoSize = true;
            this.lblH0.Location = new System.Drawing.Point(39, 44);
            this.lblH0.Name = "lblH0";
            this.lblH0.Size = new System.Drawing.Size(33, 13);
            this.lblH0.TabIndex = 14;
            this.lblH0.Text = "value";
            // 
            // lblH1
            // 
            this.lblH1.AutoSize = true;
            this.lblH1.Location = new System.Drawing.Point(39, 62);
            this.lblH1.Name = "lblH1";
            this.lblH1.Size = new System.Drawing.Size(33, 13);
            this.lblH1.TabIndex = 15;
            this.lblH1.Text = "value";
            // 
            // lblH2
            // 
            this.lblH2.AutoSize = true;
            this.lblH2.Location = new System.Drawing.Point(39, 81);
            this.lblH2.Name = "lblH2";
            this.lblH2.Size = new System.Drawing.Size(33, 13);
            this.lblH2.TabIndex = 16;
            this.lblH2.Text = "value";
            // 
            // lblH3
            // 
            this.lblH3.AutoSize = true;
            this.lblH3.Location = new System.Drawing.Point(39, 101);
            this.lblH3.Name = "lblH3";
            this.lblH3.Size = new System.Drawing.Size(33, 13);
            this.lblH3.TabIndex = 17;
            this.lblH3.Text = "value";
            // 
            // lblH4
            // 
            this.lblH4.AutoSize = true;
            this.lblH4.Location = new System.Drawing.Point(39, 121);
            this.lblH4.Name = "lblH4";
            this.lblH4.Size = new System.Drawing.Size(33, 13);
            this.lblH4.TabIndex = 18;
            this.lblH4.Text = "value";
            // 
            // StepThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 203);
            this.Controls.Add(this.lblH4);
            this.Controls.Add(this.lblH3);
            this.Controls.Add(this.lblH2);
            this.Controls.Add(this.lblH1);
            this.Controls.Add(this.lblH0);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StepThree";
            this.Text = "StepThree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.Label lblH0;
        private System.Windows.Forms.Label lblH1;
        private System.Windows.Forms.Label lblH2;
        private System.Windows.Forms.Label lblH3;
        private System.Windows.Forms.Label lblH4;
    }
}