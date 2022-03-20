using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using G191210068_Web_Muhasebe.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using G191210068_Web_Muhasebe.Models;

namespace G191210068_Web_Muhasebe.Components
{

    public class Vadeli_Islemler :ViewComponent
    {

        private readonly MuhasebeDbContext _context;

        public Vadeli_Islemler(MuhasebeDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {

            var AllCari_CariIslemler = _context.CariIslemler.ToList();
            var Cariler = _context.Cari.ToList();

            var model = from s in AllCari_CariIslemler
                        join st in Cariler on s.CariId equals st.CariID into st2
                        from st in st2.DefaultIfEmpty()
                        select new VadeliIslemler { CariIslemler = s, Cari = st };



            var vadeliIslemler = model.Where(x => x.CariIslemler.odemeSekli==Models.OdemeSekli.Açıktan).OrderByDescending(y=>y.CariIslemler.FaturaTarihi).ToList();
            return View(vadeliIslemler);
        }

    }
}


