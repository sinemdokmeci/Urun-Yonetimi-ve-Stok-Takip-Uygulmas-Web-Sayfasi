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
    public partial class UrunYonetimi : Form
    {
        public UrunYonetimi()
        {
            InitializeComponent();
        }
        UrunManager manager = new UrunManager();
        KategoriManager kategoriManager = new KategoriManager();
        MarkaManager markaManager = new MarkaManager();
        void Yukle()
        {
            dgvUrunler.DataSource = manager.GetAll();
            cbUrunKategorisi.DataSource = kategoriManager.GetAll();
            cbUrunMarkasi.DataSource = markaManager.GetAll();
        }
        void Temizle()
        {
            TxtIskonto.Text = string.Empty;
            txtKdv.Text = string.Empty;
            txtStokMiktari.Text = string.Empty;
            txtUrunAdi.Text = string.Empty;
            txtUrunFiyati.Text = string.Empty;
            cbDurum.Checked = false;
            rtbUrunAciklamasi.Text = String.Empty;
            LblId.Text = "0";
            lblEklenmeTarihi.Text = String.Empty;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UrunYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(
                new Urun
                {
                    UrunAdi = txtUrunAdi.Text,
                    UrunFiyati = decimal.Parse(txtUrunFiyati.Text),
                    Aciklama = rtbUrunAciklamasi.Text,
                    Aktif = cbDurum.Checked,
                    EklenmeTarihi = DateTime.Now,
                    İskonto = int.Parse(TxtIskonto.Text),
                    Kdv = int.Parse(txtKdv.Text),
                    StokMiktari = int.Parse(txtStokMiktari.Text),
                    ToptanFiyat = decimal.Parse(txtUrunFiyati.Text),
                    KategoriId = int.Parse(cbUrunKategorisi.SelectedValue.ToString()),
                    MarkaId = int.Parse(cbUrunMarkasi.SelectedValue.ToString())


                });
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Ürün Eklendi!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştur! Ürün Eklenemedi!n\\ Boş Alan Bırakmadan Tekrar Deneyin!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int urunId = Convert.ToInt32(LblId.Text);
                if (urunId > 0)
                {
                    var sonuc = manager.UpDate(
                new Urun
                {
                    Id = urunId,
                    UrunAdi = txtUrunAdi.Text,
                    UrunFiyati = decimal.Parse(txtUrunFiyati.Text),
                    Aciklama = rtbUrunAciklamasi.Text,
                    Aktif = cbDurum.Checked,
                    EklenmeTarihi = DateTime.Now,
                    İskonto = int.Parse(TxtIskonto.Text),
                    Kdv = int.Parse(txtKdv.Text),
                    StokMiktari = int.Parse(txtStokMiktari.Text),
                    ToptanFiyat = decimal.Parse(txtUrunFiyati.Text),
                    KategoriId = int.Parse(cbUrunKategorisi.SelectedValue.ToString()),
                    MarkaId = int.Parse(cbUrunMarkasi.SelectedValue.ToString())


                });
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Ürün Güncellendi!");
                    }
                }
                else MessageBox.Show("Listeden Bir Ürün Seçiniz?");

            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştur! Ürün Güncellenemedi!n\\ Boş Alan Bırakmadan Tekrar Deneyin!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (LblId.Text == "0")
                {
                    MessageBox.Show("Listeden silinecek kaydı seçiniz!");
                }
                else
                {
                    var sonuc = manager.Delete(int.Parse(LblId.Text));
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Ürün  Silindi!");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Ürün  Silinemedi!");
            }
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                LblId.Text = dgvUrunler.CurrentRow.Cells[0].Value.ToString();
                int urunId = Convert.ToInt32(LblId.Text);
                if (urunId > 0)
                {
                    var urun = manager.Get(urunId);
                    if (urun != null)
                    {
                        TxtIskonto.Text = urun.İskonto.ToString();
                        txtKdv.Text = urun.Kdv.ToString();
                        txtStokMiktari.Text = urun.StokMiktari.ToString();
                        txtUrunAdi.Text = urun.UrunAdi;
                        txtUrunFiyati.Text = urun.UrunFiyati.ToString();
                        rtbUrunAciklamasi.Text = urun.Aciklama;
                        cbDurum.Checked = urun.Aktif;
                        lblEklenmeTarihi.Text = urun.EklenmeTarihi.ToString();
                        cbUrunKategorisi.SelectedValue = urun.KategoriId;
                        cbUrunMarkasi.SelectedValue = urun.MarkaId;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Atanırken Hata Oluştur!");

            }
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

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
