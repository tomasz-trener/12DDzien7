using P05AplikacjaZawodnicy.Core.Domains;
using P05AplikacjaZawodnicy.Core.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01AplikacjaZawodnicy
{
    public partial class FrmStartowy : Form
    {
        public FrmStartowy()
        {
            InitializeComponent();
        }

        public void Odswiez()
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            Zawodnik[] zawodnicy = zr.PodajZawodnikow();

            //foreach (var z in zawodnicy)
            //    lvDane.Items.Add(z.Imie + " " + z.Nazwisko);

            lvDane.Items.Clear();

            foreach (var z in zawodnicy)
                lvDane.Items.Add(new ListViewItem()
                {
                    Text = z.Imie + " " + z.Nazwisko,
                    Tag = z
                });
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            Odswiez();
            btnNowy.Enabled = true;
            btnSzczegoly.Enabled = true;
        }

        private void lvDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSzczegoly_Click(object sender, EventArgs e)
        {
            Zawodnik zaznaczony= (Zawodnik)lvDane.SelectedItems[0].Tag;

            FrmSzczegoly fs = new FrmSzczegoly(this, zaznaczony);
            fs.Show();
        }

        private void btnNowy_Click(object sender, EventArgs e)
        {
            FrmSzczegoly fs = new FrmSzczegoly(this);
            fs.Show();
        }
    }
}
