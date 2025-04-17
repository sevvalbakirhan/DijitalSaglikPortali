using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DijitalSaglikPortali.Models.Entities
{
    public class SağlıkGeçmişi
    {
        public int Id { get; set; }
        public int HastalarID { get; set; }
        public string HastalıkAdı { get; set; }
        public DateTime BaşlangıçTarihi { get; set; }
        public DateTime BitişTarihi { get; set; }
        public string TedaviYöntemi { get; set; } // Örneğin: İlaç tedavisi, Fizik tedavi vb.
            
    }
}