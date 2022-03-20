using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using G191210068_Web_Muhasebe.Models;
namespace G191210068_Web_Muhasebe.Models
{
    public class Cari
    {
        public int CariID { get; set; }

        [Required(ErrorMessage ="Zorunlu Alan")]
        [Localizable(true)]
        [Display(Name = "Firma Adı")]
        public string FirmaAdi { get; set; }

        [Localizable(true)]
        [Display(Name = "Yetkili")]
        public string Yetkili { get; set; }

        [Localizable(true)]
        [Display(Name = "Telefon")]
        public string Telefon { get; set; }

        [Localizable(true)]
        [Display(Name = "Fax")]
        public string Fax { get; set; }

        [Localizable(true)]
        [DisplayName("İl")]
        public string Il { get; set; }

        [Localizable(true)]
        [DisplayName("İlçe")]
        public string Ilçe { get; set; }

        [Localizable(true)]
        [DisplayName("Adres")]
        public string Adres { get; set; }

        [Localizable(true)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Localizable(true)]
        [DisplayName("Sevk Adresi")]
        public string SevkAdresi { get; set; }

        [Localizable(true)]
        [DisplayName("Posta Kodu")]
        public string PostaKodu { get; set; }

        [Localizable(true)]
        [DisplayName("Açıklama")]
        public string Aciklama { get; set; }

        [Localizable(true)]
        [DisplayName("Toplam Borç")]
        public double ToplamBorc { get; set; }

        [Localizable(true)]
        [DisplayName("Toplam Alacak")]
        public double ToplamAlacak { get; set; }

        [Localizable(true)]
        [DisplayName("Bakiye")]
        public double Bakiye { get; set; }

        [Required(ErrorMessage = "Zorunlu alan")]
        [Localizable(true)]
        [DisplayName("Grup")]
        public Grup Grup { get; set; }

       
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
       
    }
}
