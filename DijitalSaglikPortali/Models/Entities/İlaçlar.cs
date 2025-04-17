using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DijitalSaglikPortali.Models.Entities
{
    public class İlaçlar
    {
        public int HastalarID { get; set; }
        public int DoktorlarID { get; set; }
        public int ReçeteID { get; set; } // Reçete ile ilişkilendirme
        public string İlaçAdı { get; set; } // İlaç adı
        public string KullanımTalimatı { get; set; } // İlaç nasıl kullanılacak0
        public string KullanımSıklığı { get; set; } // Örneğin: Günde 2 kez, Haftada 1 kez
        public string KullanımSüresi { get; set; } // Örneğin: 7 gün, 1 ay

    }
}