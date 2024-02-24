using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Entities;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace UrunYonetimiStokTakip
{
    public partial class KullaniciYonetimi : Form
    {
        public KullaniciYonetimi()
        {
            InitializeComponent();
        }
        KullaniciManager manager = new KullaniciManager();
        void Yukle()
        {
            dgvKullanicilar.DataSource = manager.GetAll();
        
        }
        void Temizle()
        {
            txtAdi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtKullaniciAdi.Text = string.Empty;
            txtSifre.Text = string.Empty;
            txtSoyadi.Text = string.Empty;
            cbDurum.Checked = false;
            lblId.Text = "0";
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(
                new Kullanici
                {
                    Adi = txtAdi.Text,
                    Soyadi = txtSoyadi.Text,
                    Email = txtEmail.Text,
                    KullaniciAdi = txtKullaniciAdi.Text,
                    Sifre = txtSifre.Text,
                    Aktif = cbDurum.Checked,
                    

                }) ;
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Kullanıcı Eklendi!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştur! Kullanıcı Eklenemedi!n\\ Boş Alan Bırakmadan Tekrar Deneyin!");
            }
        }

        private void KullaniciYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.UpDate(
                new Kullanici
                {
                    Id = int.Parse(lblId.Text),
                    Adi = txtAdi.Text,
                    Soyadi = txtSoyadi.Text,
                    Email = txtEmail.Text,
                    KullaniciAdi = txtKullaniciAdi.Text,
                    Sifre = txtSifre.Text,
                    Aktif = cbDurum.Checked,


                });
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Kullanıcı Güncellendi!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştur! Kullanıcı Güncellenemedi!n\\ Boş Alan Bırakmadan Tekrar Deneyin!");
            }
        }

        private void dgvKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblId.Text = dgvKullanicilar.CurrentRow.Cells[0].Value.ToString();
                txtKullaniciAdi.Text = dgvKullanicilar.CurrentRow.Cells[1].Value.ToString();
                if(dgvKullanicilar.CurrentRow.Cells[2].Value != null)txtSifre.Text = dgvKullanicilar.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dgvKullanicilar.CurrentRow.Cells[3].Value.ToString();
                txtAdi.Text = dgvKullanicilar.CurrentRow.Cells[4].Value.ToString();
                txtSoyadi.Text = dgvKullanicilar.CurrentRow.Cells[5].Value.ToString();
                cbDurum.Checked = Convert.ToBoolean(dgvKullanicilar.CurrentRow.Cells[6].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Atanırken Hata Oluştur!");

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "0")
                {
                    MessageBox.Show("Listeden silinecek kaydı seçiniz!");
                }
                else
                {
                    var sonuc = manager.Delete(int.Parse(lblId.Text));
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Kullanıcı  Silindi!");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Kullanıcı  Silinemedi!");
            }
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
