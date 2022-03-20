using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace G191210068_Web_Muhasebe.Models
{
    public class Urun
    {
        public int UrunID { get; set; }

        [Localizable(true)]
        [DisplayName("Ürün Adı")]
        public string UrunAd { get; set; }

        [Localizable(true)]
        [DisplayName("Birim")]
        public Birim Birim { get; set; }

        [Localizable(true)]
        [DisplayName("Miktar")]
        public double Miktar { get; set; }

        [Localizable(true)]
        [DisplayName("Birim Fiyat")]
        public double BirimFiyat { get; set; }

        [Localizable(true)]
        [DisplayName("İskonto")]
        public double Iskonto { get; set; }

        [Localizable(true)]
        [DisplayName("Kdv")]
        public double Kdv { get; set; }

        [Localizable(true)]
        [DisplayName("Kdv Durum")]
        public KdvDurum kdvDurum { get; set; }

        [Localizable(true)]
        [DisplayName("İskonto Türü")]
        public IskontoTuru iskontoTuru { get; set; }

        [Localizable(true)]
        [DisplayName("Toplam")]
        public double Toplam { get; set; }

        [Localizable(true)]
        [DisplayName("Genel Toplam")]
        public double GenelToplam { get; set; }

        public int? IslemID { get; set; }
        [ForeignKey("IslemID")]

        public CariIslemler CariIslemler { get; set; }

    }
}
