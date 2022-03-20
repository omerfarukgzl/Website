using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace G191210068_Web_Muhasebe.ViewModel
{
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {
            Claims = new List<string>();
            Roles = new List<string>();
        }

        public string Id { get; set; }

        [Required]
        [Localizable(true)]
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [Localizable(true)]
        [DisplayName("Email")]
        public string Email { get; set; }

        public List<string> Claims { get; set; }

        public IList<string> Roles { get; set; }
    }
}
