using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunYonetimiStokTakip
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void kullanıcıYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciYonetimi kullaniciYonetimi = new KullaniciYonetimi();
            this.Close();
            kullaniciYonetimi.ShowDialog();
        }

        private void muşteriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriYonetimi musteriYonetimi = new MusteriYonetimi();
            this.Close();
            musteriYonetimi.ShowDialog();
        }

        private void siparişYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisYonetimi siparisYonetimi = new SiparisYonetimi();
            this.Close();
            siparisYonetimi.ShowDialog();
        }

        private void kategoriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriYonetimi kategoriYonetimi = new KategoriYonetimi();
            this.Close();
            kategoriYonetimi.ShowDialog();
        }

        private void markaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkaYonetimi markaYonetimi = new MarkaYonetimi();
            this.Close();
            markaYonetimi.ShowDialog();
        }

        private void ürünYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunYonetimi urunYonetimi = new UrunYonetimi();
            this.Close();
            urunYonetimi.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
