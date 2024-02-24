namespace UrunYonetimiStokTakip
{
    partial class SiparisYonetimi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ıd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpSiparisTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbUrunler = new System.Windows.Forms.ComboBox();
            this.cbMusteriler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSiparisNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muşteriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ıd
            // 
            this.ıd.AutoSize = true;
            this.ıd.Location = new System.Drawing.Point(754, 113);
            this.ıd.Name = "ıd";
            this.ıd.Size = new System.Drawing.Size(13, 13);
            this.ıd.TabIndex = 19;
            this.ıd.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpSiparisTarihi);
            this.groupBox1.Controls.Add(this.cbUrunler);
            this.groupBox1.Controls.Add(this.cbMusteriler);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtSiparisNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Location = new System.Drawing.Point(518, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 191);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sipariş Bilgileri";
            // 
            // dtpSiparisTarihi
            // 
            this.dtpSiparisTarihi.Location = new System.Drawing.Point(107, 121);
            this.dtpSiparisTarihi.Name = "dtpSiparisTarihi";
            this.dtpSiparisTarihi.Size = new System.Drawing.Size(142, 20);
            this.dtpSiparisTarihi.TabIndex = 22;
            // 
            // cbUrunler
            // 
            this.cbUrunler.FormattingEnabled = true;
            this.cbUrunler.Location = new System.Drawing.Point(108, 90);
            this.cbUrunler.Name = "cbUrunler";
            this.cbUrunler.Size = new System.Drawing.Size(141, 21);
            this.cbUrunler.TabIndex = 21;
            // 
            // cbMusteriler
            // 
            this.cbMusteriler.FormattingEnabled = true;
            this.cbMusteriler.Location = new System.Drawing.Point(108, 60);
            this.cbMusteriler.Name = "cbMusteriler";
            this.cbMusteriler.Size = new System.Drawing.Size(141, 21);
            this.cbMusteriler.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sipariş Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Müşteri";
            // 
            // TxtSiparisNo
            // 
            this.TxtSiparisNo.Location = new System.Drawing.Point(108, 31);
            this.TxtSiparisNo.Multiline = true;
            this.TxtSiparisNo.Name = "TxtSiparisNo";
            this.TxtSiparisNo.Size = new System.Drawing.Size(141, 20);
            this.TxtSiparisNo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sipariş No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ürün";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(174, 155);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(95, 155);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(14, 155);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgvSiparisler
            // 
            this.dgvSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisler.Location = new System.Drawing.Point(12, 33);
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.Size = new System.Drawing.Size(500, 387);
            this.dgvSiparisler.TabIndex = 17;
            this.dgvSiparisler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSiparisler_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfaToolStripMenuItem,
            this.kullanıcıYönetimiToolStripMenuItem,
            this.muşteriYönetimiToolStripMenuItem,
            this.siparişYönetimiToolStripMenuItem,
            this.kategoriYönetimiToolStripMenuItem,
            this.markaToolStripMenuItem,
            this.ürünYönetimiToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaSayfaToolStripMenuItem
            // 
            this.anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            this.anaSayfaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.anaSayfaToolStripMenuItem.Text = "Ana Sayfa";
            // 
            // kullanıcıYönetimiToolStripMenuItem
            // 
            this.kullanıcıYönetimiToolStripMenuItem.Name = "kullanıcıYönetimiToolStripMenuItem";
            this.kullanıcıYönetimiToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.kullanıcıYönetimiToolStripMenuItem.Text = "Kullanıcı Yönetimi";
            this.kullanıcıYönetimiToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıYönetimiToolStripMenuItem_Click);
            // 
            // muşteriYönetimiToolStripMenuItem
            // 
            this.muşteriYönetimiToolStripMenuItem.Name = "muşteriYönetimiToolStripMenuItem";
            this.muşteriYönetimiToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.muşteriYönetimiToolStripMenuItem.Text = "Muşteri Yönetimi";
            this.muşteriYönetimiToolStripMenuItem.Click += new System.EventHandler(this.muşteriYönetimiToolStripMenuItem_Click);
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            this.siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            this.siparişYönetimiToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.siparişYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // kategoriYönetimiToolStripMenuItem
            // 
            this.kategoriYönetimiToolStripMenuItem.Name = "kategoriYönetimiToolStripMenuItem";
            this.kategoriYönetimiToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.kategoriYönetimiToolStripMenuItem.Text = "Kategori Yönetimi";
            this.kategoriYönetimiToolStripMenuItem.Click += new System.EventHandler(this.kategoriYönetimiToolStripMenuItem_Click);
            // 
            // markaToolStripMenuItem
            // 
            this.markaToolStripMenuItem.Name = "markaToolStripMenuItem";
            this.markaToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.markaToolStripMenuItem.Text = "Marka Yönetimi";
            this.markaToolStripMenuItem.Click += new System.EventHandler(this.markaToolStripMenuItem_Click);
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            this.ürünYönetimiToolStripMenuItem.Click += new System.EventHandler(this.ürünYönetimiToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // SiparisYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 426);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ıd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSiparisler);
            this.Name = "SiparisYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Yonetimi";
            this.Load += new System.EventHandler(this.SiparisYonetimi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ıd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSiparisNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgvSiparisler;
        private System.Windows.Forms.ComboBox cbUrunler;
        private System.Windows.Forms.ComboBox cbMusteriler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpSiparisTarihi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muşteriYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}