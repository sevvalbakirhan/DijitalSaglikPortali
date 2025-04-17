using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DijitalSaglikPortali.Models.Entities
{
    public class HastaneAdmin
    {
        public int HastaneAdminId{ get; set; }
        public string KullanıcıAdı { get; set; } // Hastane admininin kullanıcı adı
        public string Sifre { get; set; } // Hastane admininin şifresi
        public string Ad { get; set; } // Hastane admininin adı
        public string Soyad { get; set; } // Hastane admininin soyadı
        public string AdminResim { get; set; }

    }
}