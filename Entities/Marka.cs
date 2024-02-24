using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Marka : IEntity
    {
        public int Id { get; set; }

        public string MarkaAdi { get; set; }
        public string Aciklamasi { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public bool Aktif { get; set; }
    }
}
