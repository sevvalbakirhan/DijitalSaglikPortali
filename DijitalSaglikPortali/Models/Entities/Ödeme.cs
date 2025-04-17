using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DijitalSaglikPortali.Models.Entities
{
    public class Ödeme
    {
        public int ödeme { get; set; }
        public int HastalarID { get; set; }
        public int RandevuID { get; set; }
        public DateTime ÖdemeTarihi { get; set; }
        public string ÖdemeDurumu { get; set; } // Ödendi, Beklemede, İptal Edildi
        public string ÖdemeYöntemi { get; set; } // Kredi Kartı, Nakit, Sigorta vb.
        public string ÖdemeAçıklaması { get; set; } // Ödeme ile ilgili ek bilgiler
        public virtual Hastalar Hastalar { get; set; } // İlişkili hastalar
        public virtual Randevu Randevu { get; set; } // İlişkili randevular
        public virtual Doktorlar Doktorlar { get; set; } // İlişkili doktorlar
        public virtual ICollection<Ödeme> Ödemeler { get; set; } // İlişkili ödemeler

    }
}