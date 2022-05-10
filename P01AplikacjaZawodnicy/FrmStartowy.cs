using P05AplikacjaZawodnicy.Core.Domains;
using P05AplikacjaZawodnicy.Core.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            ZawodnicyRepository zr = new ZawodnicyRepository();

            string[] kraje = zr.PodajKraje();
            cbKraje.Items.Add("-- Wszystkie --");
            foreach (var k in kraje)
                cbKraje.Items.Add(k);


        }

        public void Odswiez()
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();

            string wybranyKraj = cbKraje.SelectedIndex == 0 ? null : cbKraje.Text;
            Zawodnik[] zawodnicy = zr.PodajZawodnikowPoKraju(wybranyKraj);

            //foreach (var z in zawodnicy)
            //    lvDane.Items.Add(z.Imie + " " + z.Nazwisko);

            ImageList listaObrazow = new ImageList();

            // var napisy = Directory.GetFiles("flagi", "pol.*").First();

            //foreach (var k   in zr.PodajKraje())
            //    if(File.Exists($@"flagi\{k.ToLower()}.jpg"))
            //        listaObrazow.Images.Add(k.ToLower(), Image.FromFile($@"flagi\{k.ToLower()}.jpg"));

            foreach (var k in zr.PodajKraje())
            {
                var p = Directory.GetFiles("flagi", $"{k}.*");
                if (p.Length > 0)
                    listaObrazow.Images.Add(k.ToLower(), Image.FromFile(p.First()));
            }

            lvDane.LargeImageList = listaObrazow;
            lvDane.Items.Clear();

            foreach (var z in zawodnicy)
                lvDane.Items.Add(new ListViewItem()
                {
                    Text = z.Imie + " " + z.Nazwisko,
                    Tag = z,
                    ImageKey = z.Kraj.ToLower()
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
            Zawodnik zaznaczony = (Zawodnik)lvDane.SelectedItems[0].Tag;

            FrmSzczegoly fs = new FrmSzczegoly(this, zaznaczony);
            fs.Show();
        }

        private void btnNowy_Click(object sender, EventArgs e)
        {
            FrmSzczegoly fs = new FrmSzczegoly(this);
            fs.Show();
        }

        private void lvDane_DoubleClick(object sender, EventArgs e)
        {
            Zawodnik zaznaczony = (Zawodnik)lvDane.SelectedItems[0].Tag;

            FrmSzczegoly fs = new FrmSzczegoly(this, zaznaczony);
            fs.Show();
        }
    }
}
