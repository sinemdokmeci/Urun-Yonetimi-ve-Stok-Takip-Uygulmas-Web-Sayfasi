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
    public partial class SiparisYonetimi : Form
    {
        public SiparisYonetimi()
        {
            InitializeComponent();
        }
        SiparisManager manager = new SiparisManager();
        MusteriManager musteri = new MusteriManager();
        UrunManager urun = new UrunManager();
        void Yukle()
        {
            dgvSiparisler.DataSource = manager.GetAll();
            cbMusteriler.DataSource = musteri.GetAll();
            cbMusteriler.DisplayMember = "Adi";
            cbMusteriler.ValueMember = "Id";
            cbUrunler.DataSource = urun.GetAll();
            cbUrunler.DisplayMember = "UrunAdi";
            cbUrunler.ValueMember = "Id";
            dgvSiparisler.Columns.Remove("Urun");
            dgvSiparisler.Columns.Remove("Musteri");

        }
        void Temizle()
        {
            TxtSiparisNo.Text = string.Empty;
            cbMusteriler.Text = string.Empty;
            cbUrunler.Text = string.Empty;
            dtpSiparisTarihi.Text = string.Empty;
            ıd.Text = "0";


        }
        private void SiparisYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(
                new Siparis
                {
                    MusteriId = Convert.ToInt32(cbMusteriler.SelectedValue),
                    SiparisNo = TxtSiparisNo.Text,
                    SiparisTarihi = dtpSiparisTarihi.Value,
                    UrunId = Convert.ToInt32(cbUrunler.SelectedValue),


                });
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Sipariş Eklendi!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştur! Sipariş Eklenemedi!n\\ Boş Alan Bırakmadan Tekrar Deneyin!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (ıd.Text != "0")
                {
                    var sonuc = manager.UpDate(
                new Siparis
                {
                    Id = Convert.ToInt32(ıd.Text),
                    MusteriId = Convert.ToInt32(cbMusteriler.SelectedValue),
                    SiparisNo = TxtSiparisNo.Text,
                    SiparisTarihi = dtpSiparisTarihi.Value,
                    UrunId = Convert.ToInt32(cbUrunler.SelectedValue),


                });
                    if (sonuc > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Sipariş Güncellendi!");
                    }
                }
                else
                { MessageBox.Show("Listeden güncellenecek kaydı seçiniz!"); }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştur! Sipariş Güncellenemedi!n\\ Boş Alan Bırakmadan Tekrar Deneyin!");
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
                        MessageBox.Show("Sipariş  Silindi!");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Sipariş  Silinemedi!");
            }
        }

        private void dgvSiparisler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var siparis = manager.Get(Convert.ToInt32(dgvSiparisler.CurrentRow.Cells[0].Value));
                TxtSiparisNo.Text = siparis.SiparisNo;
                cbMusteriler.SelectedValue = siparis.MusteriId;
                cbUrunler.SelectedValue = siparis.UrunId;
                dtpSiparisTarihi.Value = siparis.SiparisTarihi;
                ıd.Text = dgvSiparisler.CurrentRow.Cells[0].Value.ToString();
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
