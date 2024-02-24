using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Siparis : IEntity
    {
        public int Id { get; set; }
        public string SiparisNo { get; set; }
        public int MusteriId { get; set; }
        public int UrunId { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual Urun Urun { get; set; }
    }
}
