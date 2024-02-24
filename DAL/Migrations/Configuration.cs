namespace DAL.Migrations
{
    using Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "DAL.DatabaseContext";
        }

        protected override void Seed(DAL.DatabaseContext context)
        {
            if (!context.Kullanicilar.Any())
            {
                context.Kullanicilar.Add(
                    new Kullanici()
                    {
                        Aktif = true,
                        KullaniciAdi = "Admin",
                        Sifre = "123456",
                        Adi = "Admin",
                        Email = "admin@gmail.com",
                        Soyadi = "-",
                    }
                    );
                context.SaveChanges();
            }
            base.Seed(context);
        }
    }
}
