namespace P02KomunikacjaPomiedzyFormularzami
{
    partial class FrmDrugi
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
            this.txtImie = new System.Windows.Forms.TextBox();
            this.btnPrzeslij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(12, 44);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(100, 20);
            this.txtImie.TabIndex = 0;
            // 
            // btnPrzeslij
            // 
            this.btnPrzeslij.Location = new System.Drawing.Point(12, 15);
            this.btnPrzeslij.Name = "btnPrzeslij";
            this.btnPrzeslij.Size = new System.Drawing.Size(75, 23);
            this.btnPrzeslij.TabIndex = 1;
            this.btnPrzeslij.Text = "Prześlij";
            this.btnPrzeslij.UseVisualStyleBackColor = true;
            this.btnPrzeslij.Click += new System.EventHandler(this.btnPrzeslij_Click);
            // 
            // FrmDrugi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 126);
            this.Controls.Add(this.btnPrzeslij);
            this.Controls.Add(this.txtImie);
            this.Name = "FrmDrugi";
            this.Text = "FrmDrugi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.Button btnPrzeslij;
    }
}