using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GorevYoneticisi.Models
{
    public class Gorev
    {
        [Key]       
        public int gorevId { get; set; }
        [DisplayName("Görevin Açıklaması")][Required(ErrorMessage = "Görevi girmeniz gerekmektedir")]
        public string gorevAciklama { get; set; }
        [DisplayName("Görev Başlangıcı")][Required]
        public DateTime baslangicTarihi { get; set; }

        [DisplayName("Görevin Bitişi")]
        [Required]
        
        public DateTime bitisTarihi { get; set; }

        public string gorevTuru { get; set; } //günlük,haftalık veya aylık

       

    }
}
