using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace G191210068_Web_Muhasebe.ViewModel
{
    public class UserRoleViewModel
    {
        public string RoleId { get; set; }
        [Localizable(true)]
        [DisplayName("Role Adı")]
        public string RoleName { get; set; }
        public bool HasAssign { get; set; }

    }
}
