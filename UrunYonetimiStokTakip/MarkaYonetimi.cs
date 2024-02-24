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
    public partial class MarkaYonetimi : Form
    {
        public MarkaYonetimi()
        {
            InitializeComponent();
        }
        MarkaManager manager = new MarkaManager();
        void Yukle()
        {
            dgvMarkalar.DataSource = manager.GetAll();
        
        }
        private void MarkaYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Temizle()
        {
            txtMarkaAciklamasi.Text = string.Empty;    
            txtMarkaAdi.Text = string.Empty;
            LblEklenmeTarihi.Text = string.Empty;
            cbDurum.Checked = false;
            lblId.Text = "0";
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            int islemSonucu = manager.Add(
                new Marka
                {
                    MarkaAdi = txtMarkaAdi.Text,
                    Aciklamasi = txtMarkaAciklamasi.Text, 
                    Aktif = cbDurum.Checked,
                    EklenmeTarihi = DateTime.Now


                }
     
                );
            if (islemSonucu > 0)
            {
                Temizle();
                Yukle();
                MessageBox.Show("Kayıt eklendi.");
            }
            else MessageBox.Show("Kayıt eklenemedi!");
        }

        private void dgvMarkalar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMarkalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dgvMarkalar.CurrentRow.Cells[0].Value.ToString();
            txtMarkaAdi.Text = dgvMarkalar.CurrentRow.Cells[1].Value.ToString();
            txtMarkaAciklamasi.Text = dgvMarkalar.CurrentRow.Cells[2].Value.ToString();
            LblEklenmeTarihi.Text = dgvMarkalar.CurrentRow.Cells[3].Value.ToString();
            cbDurum.Checked = Convert.ToBoolean(dgvMarkalar.CurrentRow.Cells[4].Value);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblId.Text);
            if (id > 0)
            {
                int islemSonucu = manager.UpDate(
                    new Marka
                    {
                        Id = id,
                        MarkaAdi = txtMarkaAdi.Text,
                        Aciklamasi = txtMarkaAciklamasi.Text,
                        Aktif = cbDurum.Checked,
                        EklenmeTarihi = Convert.ToDateTime(LblEklenmeTarihi.Text)


                    });
                if (islemSonucu > 0)
                {
                    Temizle();
                    Yukle();
                    MessageBox.Show("Kayıt Güncellendi.");
                }
                else MessageBox.Show("Kayıt güncellenemedi!");

            }
            else MessageBox.Show("Listeden güncellenecek kaydı seçiniz.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblId.Text);
            if (id > 0)
            {
                
                if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int islemSonucu = manager.Delete(id);
                    if (islemSonucu > 0)
                    {
                        Temizle();
                        Yukle();
                        MessageBox.Show("Kayıt Silindi");
                    }
                    else MessageBox.Show("Kayıt silinemedi!");
                }
                
            }
            else MessageBox.Show("Listeden silinecek kaydı seçiniz.");
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
