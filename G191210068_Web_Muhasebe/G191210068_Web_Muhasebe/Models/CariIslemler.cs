using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace G191210068_Web_Muhasebe.Models
{
    public class CariIslemler
    {
        public int CariIslemlerID { get; set; }

        [Localizable(true)]
        [Display(Name = "Fatura Tarihi")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime FaturaTarihi { get; set; }

        [Localizable(true)]
        [Display(Name = "Sevk Tarihi")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime SevkTarihi { get; set; }

        [Localizable(true)]
        [Display(Name = "Vade Tarihi")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime VadeTarihi { get; set; }

        [Localizable(true)]
        [Display(Name = "Saat")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
        [DataType(DataType.Time)]
        public TimeSpan Saat { get; set; }

        [Localizable(true)]
        [DisplayName("Ödeme Şekli")]
        public OdemeSekli odemeSekli { get; set; }

        [Localizable(true)]
        [DisplayName("Evrak No")]
        public string EvrakNo { get; set; }

        [Localizable(true)]
        [DisplayName("Açıklama")]
        public string Aciklama { get; set; }

        [Localizable(true)]
        [DisplayName("Borç")]
        public double Borc { get; set; }

        [Localizable(true)]
        [DisplayName("Alacak")]
        public double Alacak { get; set; }

        [Localizable(true)]
        [DisplayName("Genel Toplam")]
        public double GenelToplam { get; set; }

        [Localizable(true)]
        [DisplayName("Ödenen")]
        public double Odenen { get; set; }

        [Localizable(true)]
        [DisplayName("Son Durum")]
        public double SonDurum { get; set; }

        [Localizable(true)]
        [DisplayName("İşlem Türü")]
        public IslemTuru islemTuru { get; set; }

        public int? CariId { get; set; }
        [ForeignKey("CariId")]

        public Cari Cari { get; set; }

        //public ICollection<Urun> Urun { get; set; }
    }
}
