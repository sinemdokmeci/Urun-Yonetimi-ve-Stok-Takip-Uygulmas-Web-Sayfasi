using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UrunYonetimiStokTakip.MvcUI.Models
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext()
            : base("name=DatabaseContext")
        {
           
        }



        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Kullanici> Kullanicilar { get; set; }
        public virtual DbSet<Marka> Markalar { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }
        public virtual DbSet<Musteri> Musteriler { get; set; }
        public virtual DbSet<Siparis> Siparisler { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//veritabanında oluşacak tabloların adına  s takısı gelmesini engeller
            base.OnModelCreating(modelBuilder);
        }

       
    }
}