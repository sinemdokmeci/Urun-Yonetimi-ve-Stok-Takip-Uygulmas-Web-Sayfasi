using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public  class MarkaManager
    {
        DatabaseContext context = new DatabaseContext();
        public List<Marka> GetAll() // veritaban9ında ki tüm markalar getiren
        {
            return context.Markalar.ToList();
        
        }

        public Marka Get(int id) // Sadece bir marka getirmek için
        {
            return context.Markalar.Find(id);
        
        }

        
        public int Add(Marka marka)
        {
            context.Markalar.Add(marka);
            return context.SaveChanges();
        }
        public int UpDate(Marka marka)
        {
            context.Markalar.AddOrUpdate(marka);
            return context.SaveChanges();
        }
        public int Delete(int id)
        {
            context.Markalar.Remove(Get(id));
            return context.SaveChanges();
        
        }
    }
}
