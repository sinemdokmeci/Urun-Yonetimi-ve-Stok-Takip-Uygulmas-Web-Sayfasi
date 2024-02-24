using Entities;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class DatabaseContext : DbContext
    {
        
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        

        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Kullanici> Kullanicilar { get; set; }
        public virtual DbSet<Marka> Markalar { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }
        public virtual DbSet<Musteri> Musteriler { get; set; }
        public virtual DbSet<Siparis> Siparisler { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//veritabanýnda oluþacak tablolarýn adýna  s takýsý gelmesini engeller
            base.OnModelCreating(modelBuilder);
        }

        public class DatabaseInitializer : CreateDatabaseIfNotExists<DatabaseContext>                                                   
        {
            protected override void Seed(DatabaseContext context) // veritabaný oluþturduktan sonra iþlem yapmamýzý saðlar
            {
                if (! context.Kullanicilar.Any())
                {
                    context.Kullanicilar.Add(
                        new Kullanici()
                        { 
                        Aktif = true,
                        KullaniciAdi = "Admin",
                        Sifre = "123456"
                        }
                        );
                    context.SaveChanges();
                }
                base.Seed(context);
            }
        }
    }
    
    
}