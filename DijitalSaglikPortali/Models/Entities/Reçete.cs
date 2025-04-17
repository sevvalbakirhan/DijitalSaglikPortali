using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DijitalSaglikPortali.Models.Entities
{
    public class Reçete
    {
        public int Id { get; set; }
        public int HastalarID { get; set; }
        public int DoktorlarID { get; set; }
        public DateTime ReçeteTarihi { get; set; }
        public string ReçeteDurumu { get; set; } // Örneğin: Aktif, Tamamlandı, İptal Edildi
        public string ReçeteAçıklaması { get; set; } // Reçete ile ilgili ek bilgiler
        public string ReçeteTipi { get; set; } // Örneğin: İlaç, Fizik tedavi, Diğer
        public virtual Hastalar Hastalar { get; set; } // İlişkili hastalar
        public virtual Doktorlar Doktorlar { get; set; } // İlişkili doktorlar
        public virtual ICollection<İlaçlar> İlaçlar { get; set; } // Reçeteye bağlı ilaçlar
   

    }
}