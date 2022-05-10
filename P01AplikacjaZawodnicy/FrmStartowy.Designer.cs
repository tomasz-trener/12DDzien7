namespace P01AplikacjaZawodnicy
{
    partial class FrmStartowy
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
            this.lvDane = new System.Windows.Forms.ListView();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvDane
            // 
            this.lvDane.HideSelection = false;
            this.lvDane.Location = new System.Drawing.Point(12, 41);
            this.lvDane.Name = "lvDane";
            this.lvDane.Size = new System.Drawing.Size(347, 319);
            this.lvDane.TabIndex = 0;
            this.lvDane.UseCompatibleStateImageBehavior = false;
            this.lvDane.View = System.Windows.Forms.View.List;
            this.lvDane.SelectedIndexChanged += new System.EventHandler(this.lvDane_SelectedIndexChanged);
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(12, 12);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 1;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 408);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.lvDane);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDane;
        private System.Windows.Forms.Button btnWczytaj;
    }
}

