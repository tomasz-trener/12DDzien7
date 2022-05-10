using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02KomunikacjaPomiedzyFormularzami
{
    public partial class FrmPierwszy : Form
    {
        FrmDrugi fd;

        public TextBox TxtImie
        {
            get { return txtImie; }
        }
        public FrmPierwszy()
        {
            InitializeComponent();
        }

        private void btnOtworz_Click(object sender, EventArgs e)
        {
            FrmPierwszy x = this;
            fd = new FrmDrugi(x);
            fd.Show();
        }

        private void btnPrzeslij_Click(object sender, EventArgs e)
        {
           // fd.TxtImie = new TextBox();
            fd.TxtImie.Text = txtImie.Text;
        }
    }
}
