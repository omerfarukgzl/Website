using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using G191210068_Web_Muhasebe.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G191210068_Web_Muhasebe.Components
{
    public class CariIslemler_Urun : ViewComponent
    {

        private readonly MuhasebeDbContext _context;

        public CariIslemler_Urun(MuhasebeDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(int? id)
        {
            var sonuclar = _context.Urun.Include(p => p.CariIslemler).Where(x => x.IslemID == id).OrderByDescending(z => z.UrunID);
            ViewBag.CariId = id;
            return View(sonuclar);
        }

    }
}

