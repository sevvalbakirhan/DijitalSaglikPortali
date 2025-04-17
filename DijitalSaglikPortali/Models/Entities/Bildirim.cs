using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DijitalSaglikPortali.Models.Entities
{
    public class Bildirim
    {
        public int Id { get; set; }
        public string Alıcı { get; set; }
        public string Gönderen{ get; set; } // Bildirimi gönderenin
        public string BildirimMetni { get; set; } // Bildirim içeriği
        public DateTime BildirimTarihi { get; set; } // Bildirimin gönderildiği tarih
        public bool Okundu { get; set; } // Bildirimin okunup okunmadığı durumu
        public string BildirimTipi { get; set; } // Örneğin: Randevu hatırlatıcı, Sağlık durumu güncellemesi vb.
        public virtual Hastalar Hastalar { get; set; } // İlişkili hastalar
    }
}