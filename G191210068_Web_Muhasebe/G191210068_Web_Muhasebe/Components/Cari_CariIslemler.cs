using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using G191210068_Web_Muhasebe.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G191210068_Web_Muhasebe.Components
{
   
    public class Cari_CariIslemler : ViewComponent
    {
        private readonly MuhasebeDbContext _context;

        public Cari_CariIslemler(MuhasebeDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(int id)
        {
            ViewBag.CariID = id;
            var sonuclar = _context.CariIslemler.Include(p => p.Cari).Where(x => x.CariId == id).OrderByDescending(z => z.FaturaTarihi).ThenByDescending(t=>t.Saat);

            return View(sonuclar);
        }

    }
}
