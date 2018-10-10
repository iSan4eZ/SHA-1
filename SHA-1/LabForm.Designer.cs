namespace SHA_1
{
    partial class LabForm
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
            this.txbToEncrypt = new System.Windows.Forms.TextBox();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Зашифровать это:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сюда: (сейчас сюда тупо результат выводится)";
            // 
            // txbToEncrypt
            // 
            this.txbToEncrypt.Location = new System.Drawing.Point(12, 39);
            this.txbToEncrypt.Name = "txbToEncrypt";
            this.txbToEncrypt.Size = new System.Drawing.Size(277, 20);
            this.txbToEncrypt.TabIndex = 2;
            this.txbToEncrypt.TextChanged += new System.EventHandler(this.txbToEncrypt_TextChanged);
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(12, 78);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(277, 20);
            this.txbResult.TabIndex = 3;
            // 
            // LabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 203);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.txbToEncrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LabForm";
            this.Text = "LabForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbToEncrypt;
        private System.Windows.Forms.TextBox txbResult;
    }
}