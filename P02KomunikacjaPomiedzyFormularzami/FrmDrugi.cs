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
    public partial class FrmDrugi : Form
    {
        FrmPierwszy fp;

        public TextBox TxtImie // ta właściwości to taki przekaźnik (pomost pomiedzy światem zewnetzrynm a elementem prytwanym wewnatrz tej klasy ) 
        {
            get { return txtImie; }
        }

        public FrmDrugi(FrmPierwszy fp)
        {
            InitializeComponent();
            this.fp = fp;
        }

        private void btnPrzeslij_Click(object sender, EventArgs e)
        {
            fp.TxtImie.Text = txtImie.Text;
        }
    }
}
