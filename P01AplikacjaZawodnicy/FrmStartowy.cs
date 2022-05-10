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

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            Zawodnik[] zawodnicy = zr.PodajZawodnikow();

            foreach (var z in zawodnicy)
                lvDane.Items.Add(z.Imie + " " + z.Nazwisko);


        }

        private void lvDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            FrmSzczegoly fs = new FrmSzczegoly();
            fs.Show();
        }
    }
}
