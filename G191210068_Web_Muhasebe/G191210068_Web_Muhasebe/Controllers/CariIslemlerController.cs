using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using G191210068_Web_Muhasebe.Models;
using G191210068_Web_Muhasebe.Models.Data;
using System.Globalization;
using System.Threading;

namespace G191210068_Web_Muhasebe.Controllers
{
    [Authorize(Roles = "User")]
    public class CariIslemlerController : Controller
    {
        private readonly MuhasebeDbContext _context;
        public CariIslemlerController(MuhasebeDbContext context)
        {
            _context = context;
            CultureInfo culture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }
        public async Task<IActionResult> Index(int cariId)
        {

            return View(await _context.CariIslemler.ToListAsync());
        }

        // GET: CariIslemler/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Cari");
                //return NotFound();
            }
            //var ToplamAlacak = _context.CariIslemler.Where(y => y.CariId == cariIslemler.CariId).Sum(x => x.Alacak);
            //var ToplamBorc = _context.CariIslemler.Where(y => y.CariId == cariIslemler.CariId).Sum(x => x.Borc);
            //cariIslemler.SonDurum = ToplamBorc - ToplamAlacak;
            var cariIslemler = await _context.CariIslemler.FirstOrDefaultAsync(m => m.CariIslemlerID == id);
            var ToplamAlacak = _context.CariIslemler.Include(p => p.Cari).Where(x => x.CariId == cariIslemler.CariId).Where(y=>y.FaturaTarihi<=cariIslemler.FaturaTarihi && y.Saat<=cariIslemler.Saat && y.CariIslemlerID!=cariIslemler.CariIslemlerID).Sum(t=>t.Alacak);
            var ToplamBorc= _context.CariIslemler.Include(p => p.Cari).Where(x => x.CariId == cariIslemler.CariId).Where(y => y.FaturaTarihi <= cariIslemler.FaturaTarihi && y.Saat <= cariIslemler.Saat && y.CariIslemlerID != cariIslemler.CariIslemlerID).Sum(t => t.Borc);
            cariIslemler.SonDurum = ToplamBorc - ToplamAlacak;

            await _context.SaveChangesAsync();
            if (cariIslemler == null)
            {
                return RedirectToAction("Index", "Cari");
                //return NotFound();
            }

            return View(cariIslemler);
        }

        // GET: CariIslemler/Create
        public IActionResult Create(int? id,IslemTuru islemTuru)
        {
            ViewBag.CariID=id;
            ViewBag.FirmaAdi = _context.Cari.Where(x => x.CariID == id).FirstOrDefault().FirmaAdi;
            ViewBag.islemTuru = islemTuru;
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CariIslemlerID,FaturaTarihi,SevkTarihi,VadeTarihi,Saat,odemeSekli,EvrakNo,Borc,Alacak,islemTuru,CariId")] CariIslemler cariIslemler)
        {
          //  var kontrol = _context.Urun.Include(p => p.CariIslemler).Where(x => x.IslemID ==cariIslemler.CariId).ToList().Count();
            if (ModelState.IsValid)
            {
                cariIslemler.Aciklama = "- " +cariIslemler.islemTuru.ToString();
                _context.Add(cariIslemler);
                await _context.SaveChangesAsync();
               // var son = _context.CariIslemler.OrderByDescending(p => p.CariIslemlerID).FirstOrDefault();
                var Id = cariIslemler.CariIslemlerID;
                return RedirectToAction("Create", "Urun",new { id= Id });
              //  return RedirectToAction(nameof(Index));
            }
             return View(cariIslemler);          
        }

        // GET: CariIslemler/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null)
            {
                return RedirectToAction("Index", "Cari");
                //return NotFound();
            }

            var cariIslemler = await _context.CariIslemler.FindAsync(id);          
            if (cariIslemler == null)
            {
                return RedirectToAction("Index", "Cari");
                //return NotFound();
            }
            ViewBag.GenelToplam = cariIslemler.GenelToplam;
            ViewBag.CariId = cariIslemler.CariId;
            ViewBag.Borc = cariIslemler.Borc;
            ViewBag.Alacak = cariIslemler.Alacak;
            ViewBag.IslemTuru = cariIslemler.islemTuru;
            return View(cariIslemler);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CariIslemlerID,FaturaTarihi,SevkTarihi,VadeTarihi,Saat,odemeSekli,EvrakNo,Aciklama,Borc,Alacak,islemTuru,CariId,GenelToplam")] CariIslemler cariIslemler)
        {
            if (id != cariIslemler.CariIslemlerID)
            {
                return RedirectToAction("Index", "Cari");
                //return NotFound();
            }

            if (ModelState.IsValid)
            {
               
                try
                {
                    cariIslemler.SonDurum = cariIslemler.SonDurum;
                    _context.Update(cariIslemler);
                    await _context.SaveChangesAsync();
                    
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CariIslemlerExists(cariIslemler.CariIslemlerID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "Cari", new { id = cariIslemler.CariId });
                //return RedirectToAction(nameof(Index));
            }
            return View(cariIslemler);
        }

        // GET: CariIslemler/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Cari");
                //return NotFound();
            }

            var cariIslemler = await _context.CariIslemler
                .FirstOrDefaultAsync(m => m.CariIslemlerID == id);
            if (cariIslemler == null)
            {
                return RedirectToAction("Index", "Cari");
                //return NotFound();
            }

            return View(cariIslemler);
        }


        // POST: CariIslemler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Cari");
                //return NotFound();
            }

            var cariIslemler = await _context.CariIslemler.FindAsync(id);
            var CariId = cariIslemler.CariId;
            _context.CariIslemler.Remove(cariIslemler);
            var cariIslemler_urun = _context.Urun.Include(p => p.CariIslemler).Where(x => x.IslemID == id).ToList();
            foreach (var item in cariIslemler_urun)
            {
                _context.Urun.Remove(item);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Cari", new { id = CariId });
        }
        public async Task<IActionResult> Cancel(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Cari");
                //return NotFound();
            }

            var cariIslemler = await _context.CariIslemler.FindAsync(id);
            var CariId = cariIslemler.CariId;
            _context.CariIslemler.Remove(cariIslemler);
            var cariIslemler_urun = _context.Urun.Include(p => p.CariIslemler).Where(x => x.IslemID == id).ToList();
            foreach (var item in cariIslemler_urun)
            {
                _context.Urun.Remove(item);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Cari");
        }
        public async Task<IActionResult> Kontrol(int? id)
        {

            if (id == null)
            {
                return RedirectToAction("Index", "Cari");
                //return NotFound();
            }

            var cariIslemler = await _context.CariIslemler.FindAsync(id);
            var TumToplam = _context.Urun.Include(p => p.CariIslemler).Where(x => x.IslemID == id).Select(y=>y.GenelToplam).Sum();
            if (cariIslemler == null)
            {
                return RedirectToAction("Index", "Cari");
                //return NotFound();
            }
            ViewBag.GenelToplam = TumToplam;
            ViewBag.CariId = cariIslemler.CariId;
            ViewBag.Borc = cariIslemler.Borc;
            ViewBag.Alacak = cariIslemler.Alacak;
            ViewBag.IslemTuru = cariIslemler.islemTuru;
            ViewBag.FirmaAdi = _context.Cari.Where(x => x.CariID == cariIslemler.CariId).FirstOrDefault().FirmaAdi;

            return View(cariIslemler);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Kontrol(int id, [Bind("CariIslemlerID,FaturaTarihi,SevkTarihi,VadeTarihi,Saat,odemeSekli,EvrakNo,Aciklama,islemTuru,GenelToplam,CariId")] CariIslemler cariIslemler)
        {
            //Cari CariIslem_CariSec;
            if (id != cariIslemler.CariIslemlerID)
            {
                return RedirectToAction("Index", "Cari");
                //return NotFound();
            }

            if (ModelState.IsValid)
            {

                try
                {
                  
                    if (cariIslemler.islemTuru == IslemTuru.Alis && cariIslemler.odemeSekli == OdemeSekli.Nakit)
                    {
                        cariIslemler.Borc = cariIslemler.GenelToplam;
                        cariIslemler.Alacak = cariIslemler.GenelToplam;

                    }
                    if (cariIslemler.islemTuru == IslemTuru.Alis && cariIslemler.odemeSekli == OdemeSekli.Açıktan)
                    {
                        cariIslemler.Borc = 0;
                        cariIslemler.Alacak = cariIslemler.GenelToplam;

                    }
                    if (cariIslemler.islemTuru == IslemTuru.Satis && cariIslemler.odemeSekli == OdemeSekli.Nakit)
                    {
                        cariIslemler.Borc = cariIslemler.GenelToplam;
                        cariIslemler.Alacak = cariIslemler.GenelToplam;

                    }
                    if (cariIslemler.islemTuru == IslemTuru.Satis && cariIslemler.odemeSekli == OdemeSekli.Açıktan)
                    {
                        cariIslemler.Borc = cariIslemler.GenelToplam;
                        cariIslemler.Alacak = 0;

                    }
                    _context.Update(cariIslemler);
                    await _context.SaveChangesAsync();


                    //var  GenelToplam = _context.CariIslemler.Include(p => p.Cari).Where(x => x.CariId == cariIslemler.CariId).Select(y => y.GenelToplam).Sum();
                    //CariIslem_CariSec = _context.Cari.Where(x => x.CariID == cariIslemler.CariId).FirstOrDefault();
                    //CariIslem_CariSec.ToplamAlacak = GenelToplam;
                    //await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CariIslemlerExists(cariIslemler.CariIslemlerID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "Cari", new { id = cariIslemler.CariId});
                //return RedirectToAction(nameof(Index));
            }
            return View(cariIslemler);
        }
        private bool CariIslemlerExists(int id)
        {
            return _context.CariIslemler.Any(e => e.CariIslemlerID == id);
        }
        public IActionResult OdemeYap(int? id)
        {
            ViewBag.CariID = id;
            ViewBag.FirmaAdi = _context.Cari.Where(x => x.CariID == id).FirstOrDefault().FirmaAdi;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OdemeYap([Bind("CariIslemlerID,FaturaTarihi,SevkTarihi,VadeTarihi,Saat,odemeSekli,EvrakNo,Aciklama,Borc,islemTuru,CariId")] CariIslemler cariIslemler)
        {
            //  var kontrol = _context.Urun.Include(p => p.CariIslemler).Where(x => x.IslemID ==cariIslemler.CariId).ToList().Count();
            if (ModelState.IsValid)
            {
                cariIslemler.Aciklama = "- Ödeme: " + cariIslemler.Aciklama;
                var ToplamAlacak = _context.CariIslemler.Where(y => y.CariId == cariIslemler.CariId).Sum(x => x.Alacak);
                var ToplamBorc = _context.CariIslemler.Where(y => y.CariId == cariIslemler.CariId).Sum(x => x.Borc);
                cariIslemler.SonDurum = ToplamBorc - ToplamAlacak;
                cariIslemler.Alacak = 0;
                _context.Add(cariIslemler);
                await _context.SaveChangesAsync();
                // var son = _context.CariIslemler.OrderByDescending(p => p.CariIslemlerID).FirstOrDefault();
                var Id = cariIslemler.CariIslemlerID;
                return RedirectToAction("Details", "Cari", new { id = cariIslemler.CariId });
                //  return RedirectToAction(nameof(Index));
            }
            return View(cariIslemler);
        }
        public IActionResult Alacaklandir(int? id)
        {
            ViewBag.CariID = id;
            ViewBag.FirmaAdi = _context.Cari.Where(x => x.CariID == id).FirstOrDefault().FirmaAdi;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Alacaklandir([Bind("CariIslemlerID,FaturaTarihi,SevkTarihi,VadeTarihi,Saat,odemeSekli,EvrakNo,Aciklama,Alacak,islemTuru,CariId")] CariIslemler cariIslemler)
        {
            //  var kontrol = _context.Urun.Include(p => p.CariIslemler).Where(x => x.IslemID ==cariIslemler.CariId).ToList().Count();
            if (ModelState.IsValid)
            {
                cariIslemler.Aciklama = " - Cariyi Alacaklandırma: " + cariIslemler.Aciklama;
                var ToplamAlacak = _context.CariIslemler.Where(y => y.CariId == cariIslemler.CariId).Sum(x => x.Alacak);
                var ToplamBorc = _context.CariIslemler.Where(y => y.CariId == cariIslemler.CariId).Sum(x => x.Borc);
                cariIslemler.SonDurum = ToplamBorc - ToplamAlacak;
                cariIslemler.Borc = 0;
                _context.Add(cariIslemler);
                await _context.SaveChangesAsync();
                // var son = _context.CariIslemler.OrderByDescending(p => p.CariIslemlerID).FirstOrDefault();
                var Id = cariIslemler.CariId;
                return RedirectToAction("Details", "Cari", new { id = Id });
                //  return RedirectToAction(nameof(Index));
            }
            return View(cariIslemler);
        }
        public IActionResult Borclandir(int? id)
        {
            ViewBag.CariID = id;
            ViewBag.FirmaAdi = _context.Cari.Where(x => x.CariID == id).FirstOrDefault().FirmaAdi;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Borclandir([Bind("CariIslemlerID,FaturaTarihi,SevkTarihi,VadeTarihi,Saat,odemeSekli,EvrakNo,Aciklama,Borc,islemTuru,CariId")] CariIslemler cariIslemler)
        {
            //  var kontrol = _context.Urun.Include(p => p.CariIslemler).Where(x => x.IslemID ==cariIslemler.CariId).ToList().Count();
            if (ModelState.IsValid)
            {
                cariIslemler.Aciklama = " - Cariyi Borçlandırma: " + cariIslemler.Aciklama;
                var ToplamAlacak = _context.CariIslemler.Where(y => y.CariId == cariIslemler.CariId).Sum(x => x.Alacak);
                var ToplamBorc = _context.CariIslemler.Where(y => y.CariId == cariIslemler.CariId).Sum(x => x.Borc);
                cariIslemler.SonDurum = ToplamBorc - ToplamAlacak;
                cariIslemler.Alacak = 0;
                _context.Add(cariIslemler);
                await _context.SaveChangesAsync();
                // var son = _context.CariIslemler.OrderByDescending(p => p.CariIslemlerID).FirstOrDefault();
                var Id = cariIslemler.CariId;
                return RedirectToAction("Details", "Cari", new { id = Id });
                //  return RedirectToAction(nameof(Index));
            }
            return View(cariIslemler);
        }
    }
}
