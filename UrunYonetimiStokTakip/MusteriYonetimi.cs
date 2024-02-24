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
    public partial class MusteriYonetimi : Form
    {
        public MusteriYonetimi()
        {
            InitializeComponent();
        }
        MusteriManager manager = new MusteriManager();
        void Yukle()
        {
            dgvMusteriler.DataSource = manager.GetAll();

        }
        void Temizle()
        {
            txtAdi.Text = string.Empty;
            txtSoyadi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefon.Text = string.Empty;
            
            ıd.Text = "0";
            

        }
        private void MusteriYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(
                new Musteri
                {
                    Adi = txtAdi.Text,
                    Soyadi = txtSoyadi.Text,
                    Email = txtEmail.Text,
                    Telefon = txtTelefon.Text,
                    

                });
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Müsteri Eklendi!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştur! Müşteri Eklenemedi!n\\ Boş Alan Bırakmadan Tekrar Deneyin!");
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.UpDate(
                new Musteri
                {
                    Id = int.Parse(ıd.Text),
                    Adi = txtAdi.Text,
                    Soyadi = txtSoyadi.Text,
                    Email= txtEmail.Text,
                    Telefon = txtTelefon.Text,
                    

                });
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Müşteri  Güncellendi!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştur! Müşteri Güncellenemedi!n\\ Boş Alan Bırakmadan Tekrar Deneyin!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (ıd.Text == "0")
                {
                    MessageBox.Show("Listeden silinecek kaydı seçiniz!");
                }
                else
                {
                    var sonuc = manager.Delete(int.Parse(ıd.Text));
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Müşteri  Silindi!");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Kayıt  Silinemedi!");
            }
        }

        private void dgvMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ıd.Text = dgvMusteriler.CurrentRow.Cells[0].Value.ToString();
                txtAdi.Text = dgvMusteriler.CurrentRow.Cells[1].Value.ToString();
                txtSoyadi.Text = dgvMusteriler.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dgvMusteriler.CurrentRow.Cells[3].Value.ToString();
                txtTelefon.Text = dgvMusteriler.CurrentRow.Cells[4].Value.ToString();
                
                
            }
            catch (Exception)
            {
                MessageBox.Show("Müşteri Atanırken Hata Oluştur!");

            }
        }

        private void kullanıcıYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciYonetimi kullaniciYonetimi = new KullaniciYonetimi();
            this.Close();
            kullaniciYonetimi.ShowDialog();
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
