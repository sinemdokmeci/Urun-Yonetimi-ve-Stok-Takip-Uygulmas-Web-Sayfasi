namespace UrunYonetimiStokTakip
{
    partial class MarkaYonetimi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblEklenmeTarihi = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cbDurum = new System.Windows.Forms.CheckBox();
            this.txtMarkaAciklamasi = new System.Windows.Forms.TextBox();
            this.txtMarkaAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMarkalar = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkalar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblEklenmeTarihi);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.cbDurum);
            this.groupBox1.Controls.Add(this.txtMarkaAciklamasi);
            this.groupBox1.Controls.Add(this.txtMarkaAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(518, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 165);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marka Yönetimi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LblEklenmeTarihi
            // 
            this.LblEklenmeTarihi.AutoSize = true;
            this.LblEklenmeTarihi.Location = new System.Drawing.Point(116, 111);
            this.LblEklenmeTarihi.Name = "LblEklenmeTarihi";
            this.LblEklenmeTarihi.Size = new System.Drawing.Size(10, 13);
            this.LblEklenmeTarihi.TabIndex = 9;
            this.LblEklenmeTarihi.Text = "-";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(206, 111);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "0";
            this.lblId.Visible = false;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(174, 131);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(95, 131);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(14, 131);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cbDurum
            // 
            this.cbDurum.AutoSize = true;
            this.cbDurum.Location = new System.Drawing.Point(119, 86);
            this.cbDurum.Name = "cbDurum";
            this.cbDurum.Size = new System.Drawing.Size(57, 17);
            this.cbDurum.TabIndex = 5;
            this.cbDurum.Text = "Durum";
            this.cbDurum.UseVisualStyleBackColor = true;
            // 
            // txtMarkaAciklamasi
            // 
            this.txtMarkaAciklamasi.Location = new System.Drawing.Point(119, 55);
            this.txtMarkaAciklamasi.Multiline = true;
            this.txtMarkaAciklamasi.Name = "txtMarkaAciklamasi";
            this.txtMarkaAciklamasi.Size = new System.Drawing.Size(100, 20);
            this.txtMarkaAciklamasi.TabIndex = 4;
            // 
            // txtMarkaAdi
            // 
            this.txtMarkaAdi.Location = new System.Drawing.Point(119, 25);
            this.txtMarkaAdi.Name = "txtMarkaAdi";
            this.txtMarkaAdi.Size = new System.Drawing.Size(100, 20);
            this.txtMarkaAdi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Eklenme Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka Açıklaması";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka Adı";
            // 
            // dgvMarkalar
            // 
            this.dgvMarkalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarkalar.Location = new System.Drawing.Point(12, 33);
            this.dgvMarkalar.Name = "dgvMarkalar";
            this.dgvMarkalar.Size = new System.Drawing.Size(500, 381);
            this.dgvMarkalar.TabIndex = 5;
            this.dgvMarkalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarkalar_CellClick);
            this.dgvMarkalar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarkalar_CellContentClick);
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
            this.menuStrip1.TabIndex = 7;
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
            this.siparişYönetimiToolStripMenuItem.Click += new System.EventHandler(this.siparişYönetimiToolStripMenuItem_Click);
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
            // MarkaYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 426);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMarkalar);
            this.Name = "MarkaYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarkaYonetimi";
            this.Load += new System.EventHandler(this.MarkaYonetimi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkalar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.CheckBox cbDurum;
        private System.Windows.Forms.TextBox txtMarkaAciklamasi;
        private System.Windows.Forms.TextBox txtMarkaAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMarkalar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label LblEklenmeTarihi;
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