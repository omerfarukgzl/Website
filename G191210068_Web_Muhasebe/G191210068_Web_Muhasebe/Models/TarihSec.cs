using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace G191210068_Web_Muhasebe.Models
{
    public class TarihSec
    {
        [Display(Name = "İlk Fatura Tarihi")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime IlkFaturaTarihi { get; set; }

        [Display(Name = "Son Fatura Tarihi")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime SonFaturaTarihi { get; set; }
    }
}
