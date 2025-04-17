using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DijitalSaglikPortali.Models.Entities
{
    public class Randevu
    {
        public int Id { get; set; }
        public int HastalarID { get; set; }
        public int DoktorlarID { get; set; }
        public DateTime RandevuTarihi { get; set; }
        public string RandevuSaati { get; set; }
        public string Durum { get; set; } // Beklemede, Onaylı, İptal Edildi
        public string Aciklama { get; set; } // Randevu ile ilgili ek bilgiler
      
        public string RandevuTuru { get; set; } // Muayene, Kontrol, Telekonsültasyon vb.
        public virtual Hastalar Hastalar { get; set; } // İlişkili hastalar
        public virtual Doktorlar Doktorlar { get; set; } // İlişkili doktorlar

    }
}