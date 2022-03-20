using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace G191210068_Web_Muhasebe.ViewModel
{
    public class SubjectModel
    {
        public SubjectModel()
        {
            SubjectList = new List<SelectListItem>();
        }

        [DisplayName("Subjects")]
        public List<SelectListItem> SubjectList
        {
            get;
            set;
        }
    }
}
