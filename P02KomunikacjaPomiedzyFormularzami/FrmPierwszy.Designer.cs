namespace P02KomunikacjaPomiedzyFormularzami
{
    partial class FrmPierwszy
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
            this.btnPrzeslij = new System.Windows.Forms.Button();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.btnOtworz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrzeslij
            // 
            this.btnPrzeslij.Location = new System.Drawing.Point(12, 12);
            this.btnPrzeslij.Name = "btnPrzeslij";
            this.btnPrzeslij.Size = new System.Drawing.Size(75, 23);
            this.btnPrzeslij.TabIndex = 0;
            this.btnPrzeslij.Text = "Prześlij";
            this.btnPrzeslij.UseVisualStyleBackColor = true;
            this.btnPrzeslij.Click += new System.EventHandler(this.btnPrzeslij_Click);
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(12, 50);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(100, 20);
            this.txtImie.TabIndex = 1;
            // 
            // btnOtworz
            // 
            this.btnOtworz.Location = new System.Drawing.Point(149, 12);
            this.btnOtworz.Name = "btnOtworz";
            this.btnOtworz.Size = new System.Drawing.Size(75, 23);
            this.btnOtworz.TabIndex = 2;
            this.btnOtworz.Text = "Otwórz";
            this.btnOtworz.UseVisualStyleBackColor = true;
            this.btnOtworz.Click += new System.EventHandler(this.btnOtworz_Click);
            // 
            // FrmPierwszy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 117);
            this.Controls.Add(this.btnOtworz);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.btnPrzeslij);
            this.Name = "FrmPierwszy";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrzeslij;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.Button btnOtworz;
    }
}

