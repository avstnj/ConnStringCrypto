namespace ConnStringCrypto
{
    partial class Form1
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
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.btnCrypto = new System.Windows.Forms.Button();
            this.btnDeCrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(25, 36);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(714, 22);
            this.txtSource.TabIndex = 0;
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(25, 76);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(714, 22);
            this.txtDest.TabIndex = 0;
            // 
            // btnCrypto
            // 
            this.btnCrypto.Location = new System.Drawing.Point(25, 104);
            this.btnCrypto.Name = "btnCrypto";
            this.btnCrypto.Size = new System.Drawing.Size(86, 37);
            this.btnCrypto.TabIndex = 1;
            this.btnCrypto.Text = "Crypt";
            this.btnCrypto.UseVisualStyleBackColor = true;
            this.btnCrypto.Click += new System.EventHandler(this.btnCrypto_Click);
            // 
            // btnDeCrypt
            // 
            this.btnDeCrypt.Location = new System.Drawing.Point(117, 104);
            this.btnDeCrypt.Name = "btnDeCrypt";
            this.btnDeCrypt.Size = new System.Drawing.Size(86, 37);
            this.btnDeCrypt.TabIndex = 1;
            this.btnDeCrypt.Text = "DeCrypt";
            this.btnDeCrypt.UseVisualStyleBackColor = true;
            this.btnDeCrypt.Click += new System.EventHandler(this.btnDeCrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeCrypt);
            this.Controls.Add(this.btnCrypto);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.txtSource);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Button btnCrypto;
        private System.Windows.Forms.Button btnDeCrypt;
    }
}

