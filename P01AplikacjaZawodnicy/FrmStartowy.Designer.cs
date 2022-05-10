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
            this.btnSzczegoly = new System.Windows.Forms.Button();
            this.btnNowy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKraje = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lvDane
            // 
            this.lvDane.HideSelection = false;
            this.lvDane.Location = new System.Drawing.Point(12, 72);
            this.lvDane.Name = "lvDane";
            this.lvDane.Size = new System.Drawing.Size(347, 288);
            this.lvDane.TabIndex = 0;
            this.lvDane.UseCompatibleStateImageBehavior = false;
            this.lvDane.SelectedIndexChanged += new System.EventHandler(this.lvDane_SelectedIndexChanged);
            this.lvDane.DoubleClick += new System.EventHandler(this.lvDane_DoubleClick);
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(12, 43);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 1;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // btnSzczegoly
            // 
            this.btnSzczegoly.Enabled = false;
            this.btnSzczegoly.Location = new System.Drawing.Point(284, 43);
            this.btnSzczegoly.Name = "btnSzczegoly";
            this.btnSzczegoly.Size = new System.Drawing.Size(75, 23);
            this.btnSzczegoly.TabIndex = 2;
            this.btnSzczegoly.Text = "Szczegóły";
            this.btnSzczegoly.UseVisualStyleBackColor = true;
            this.btnSzczegoly.Click += new System.EventHandler(this.btnSzczegoly_Click);
            // 
            // btnNowy
            // 
            this.btnNowy.Enabled = false;
            this.btnNowy.Location = new System.Drawing.Point(203, 43);
            this.btnNowy.Name = "btnNowy";
            this.btnNowy.Size = new System.Drawing.Size(75, 23);
            this.btnNowy.TabIndex = 3;
            this.btnNowy.Text = "Nowy";
            this.btnNowy.UseVisualStyleBackColor = true;
            this.btnNowy.Click += new System.EventHandler(this.btnNowy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kraj";
            // 
            // cbKraje
            // 
            this.cbKraje.FormattingEnabled = true;
            this.cbKraje.Location = new System.Drawing.Point(259, 12);
            this.cbKraje.Name = "cbKraje";
            this.cbKraje.Size = new System.Drawing.Size(100, 21);
            this.cbKraje.TabIndex = 6;
            // 
            // FrmStartowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 375);
            this.Controls.Add(this.cbKraje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNowy);
            this.Controls.Add(this.btnSzczegoly);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.lvDane);
            this.Name = "FrmStartowy";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDane;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.Button btnSzczegoly;
        private System.Windows.Forms.Button btnNowy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKraje;
    }
}

