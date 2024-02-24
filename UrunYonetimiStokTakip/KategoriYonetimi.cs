using BL;
using Entities;
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
    public partial class KategoriYonetimi : Form
    {
        public KategoriYonetimi()
        {
            InitializeComponent();
        }
        KategoriManager manager = new KategoriManager();
        void Yukle()
        {
            dgvKategori.DataSource = manager.GetAll();
        
        }
        void Temizle()
        {
            txtKategoriAdi.Text = string.Empty;
            txtKategoriAciklamasi.Text = string.Empty;
            lblEklenmeTarihi.Text = string.Empty;
            lblıd.Text = "0";
            cbDurum.Checked = false;
        
        }
        private void KategoriYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(
                new Kategori
                {
                    KategoriAdi = txtKategoriAdi.Text,
                    KategoriAciklamasi = txtKategoriAciklamasi.Text,
                    Aktif = cbDurum.Checked,
                    EklenmeTarihi = DateTime.Now

                });
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Kayıt Eklendi!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştur! Kayıt Eklenemedi!n\\ Boş Alan Bırakmadan Tekrar Deneyin!");
            }
            
                
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.UpDate(
                new Kategori
                {
                    Id = int.Parse(lblıd.Text),
                    KategoriAdi = txtKategoriAdi.Text,
                    KategoriAciklamasi = txtKategoriAciklamasi.Text,
                    Aktif = cbDurum.Checked,
                    EklenmeTarihi = Convert.ToDateTime(lblEklenmeTarihi.Text)

                });
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Kayıt  Güncellendi!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştur! Kayıt Güncellenemedi!n\\ Boş Alan Bırakmadan Tekrar Deneyin!");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblıd.Text == "0")
                {
                    MessageBox.Show("Listeden silinecek kaydı seçiniz!");
                }
                else
                {
                    var sonuc = manager.Delete(int.Parse(lblıd.Text));
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Kayıt  Silindi!");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Kayıt  Silinemedi!");
            }

        }

        private void dgvKategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblıd.Text = dgvKategori.CurrentRow.Cells[0].Value.ToString();
                txtKategoriAdi.Text = dgvKategori.CurrentRow.Cells[1].Value.ToString();
                txtKategoriAciklamasi.Text = dgvKategori.CurrentRow.Cells[2].Value.ToString();
                lblEklenmeTarihi.Text = dgvKategori.CurrentRow.Cells[3].Value.ToString();
                cbDurum.Checked = Convert.ToBoolean(dgvKategori.CurrentRow.Cells[4].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Atanırken Hata Oluştur!");

            }
            
        }

        private void kategoriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
