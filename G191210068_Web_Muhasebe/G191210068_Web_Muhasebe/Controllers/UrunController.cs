using System;
using System.Collections.Generic;
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
    public class UrunController : Controller
    {

        private readonly MuhasebeDbContext _context;

        public UrunController(MuhasebeDbContext context)
        {
            _context = context;
            CultureInfo culture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }

        // GET: Urun
        public async Task<IActionResult> Index()
        {
            return View(await _context.Urun.ToListAsync());
        }

        // GET: Urun/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Cari");
                //return NotFound();
            }

            var urun = await _context.Urun
                .FirstOrDefaultAsync(m => m.UrunID == id);
            var islemId = _context.Urun.Where(x => x.UrunID == id).Select(y => y.IslemID).FirstOrDefault();
            ViewBag.CariIslemID = islemId;

            var cariIslem = _context.CariIslemler.Where(x => x.CariIslemlerID == urun.IslemID).FirstOrDefault();
            var firmaad = _context.Cari.Where(x => x.CariID == cariIslem.CariId).FirstOrDefault().FirmaAdi;
            ViewBag.FirmaAdi = firmaad;


            var faturatarihi = _context.CariIslemler.Where(x => x.CariIslemlerID == islemId).Select(y => y.FaturaTarihi).FirstOrDefault();
            ViewBag.FaturaTarihi = faturatarihi;

            if (urun == null)
            {
                return NotFound();
            }

            return View(urun);
        }

        // GET: Urun/Create
        public IActionResult Create(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Cari");
                //return NotFound();
            }
            var cariID= _context.CariIslemler.Where(x => x.CariIslemlerID == id).FirstOrDefault().CariId;
            var firmaAdi= _context.Cari.Where(x => x.CariID == cariID).FirstOrDefault().FirmaAdi;
            ViewBag.FirmaAdi = firmaAdi;
            ViewBag.CariIslemID = id;
            return View();
        }

        // POST: Urun/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UrunID,UrunAd,Birim,Miktar,BirimFiyat,Iskonto,Kdv,kdvDurum,iskontoTuru,Toplam,GenelToplam,IslemID")] Urun urun)
        {
            if (ModelState.IsValid)
            {             
                _context.Add(urun);
                await _context.SaveChangesAsync();
                var IslemId = _context.Urun.Where(x => x.IslemID == urun.IslemID).Select(p => p.IslemID).FirstOrDefault();
               // var cariId= _context.CariIslemler.Where(x => x.CariIslemlerID == Islem).Select(y=>y.CariId).FirstOrDefault();
                return RedirectToAction("Kontrol", "CariIslemler", new { id = IslemId });
                //return RedirectToAction(nameof(Index));
            }
            return View(urun);
        }

        // GET: Urun/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Cari");
                //return NotFound();
            }
            var islemId = _context.Urun.Where(x => x.UrunID == id).Select(y=>y.IslemID).FirstOrDefault();
            ViewBag.CariIslemID = islemId;
            var urun = await _context.Urun.FindAsync(id);
            if (urun == null)
            {
                return NotFound();
            }
            return View(urun);
        }

        // POST: Urun/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UrunID,UrunAd,Birim,Miktar,BirimFiyat,Iskonto,Kdv,kdvDurum,iskontoTuru,Toplam,GenelToplam,IslemID")] Urun urun)
        {
            if (id != urun.UrunID)
            {
                return RedirectToAction("Index", "Cari");
                //return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(urun);
                    var cariIslemler = _context.CariIslemler.FirstOrDefault(x => x.CariIslemlerID == urun.IslemID);

                    var ToplamAlacak = _context.CariIslemler.Where(y => y.CariId == cariIslemler.CariId).Sum(x => x.Alacak);
                    var ToplamBorc = _context.CariIslemler.Where(y => y.CariId == cariIslemler.CariId).Sum(x => x.Borc);
                    cariIslemler.SonDurum = ToplamAlacak - ToplamBorc;

                    if (cariIslemler.islemTuru == IslemTuru.Alis && cariIslemler.odemeSekli == OdemeSekli.Nakit)
                    {
                        cariIslemler.Borc = cariIslemler.GenelToplam + urun.GenelToplam;
                        cariIslemler.Alacak = cariIslemler.GenelToplam + urun.GenelToplam;

                    }
                    if (cariIslemler.islemTuru == IslemTuru.Alis && cariIslemler.odemeSekli == OdemeSekli.Açıktan)
                    {
                        cariIslemler.Borc = 0;
                        cariIslemler.Alacak = cariIslemler.GenelToplam + urun.GenelToplam;

                    }
                    if (cariIslemler.islemTuru == IslemTuru.Satis && cariIslemler.odemeSekli == OdemeSekli.Nakit)
                    {
                        cariIslemler.Borc = cariIslemler.GenelToplam + urun.GenelToplam;
                        cariIslemler.Alacak = cariIslemler.GenelToplam + urun.GenelToplam;

                    }
                    if (cariIslemler.islemTuru == IslemTuru.Satis && cariIslemler.odemeSekli == OdemeSekli.Açıktan)
                    {
                        cariIslemler.Borc = cariIslemler.GenelToplam + urun.GenelToplam;
                        cariIslemler.Alacak = 0;

                    }
                    _context.Update(cariIslemler);
                    await _context.SaveChangesAsync();
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UrunExists(urun.UrunID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "CariIslemler", new { id = urun.IslemID });
            }
            return View(urun);
        }

        // GET: Urun/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Cari");
                //return NotFound();
            }

            var urun = await _context.Urun
                .FirstOrDefaultAsync(m => m.UrunID == id);
            ViewBag.CariIslemID = urun.IslemID;
            if (urun == null)
            {
                return NotFound();
            }

            return View(urun);
        }

        // POST: Urun/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var urun = await _context.Urun.FindAsync(id);
            var CariIslemid = urun.IslemID;
            _context.Urun.Remove(urun);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "CariIslemler", new { id = CariIslemid });
        }

        public async Task<IActionResult> Cancel(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Cari");
                //return NotFound();
            }

            var cariIslemler = await _context.CariIslemler.FindAsync(id);

            _context.CariIslemler.Remove(cariIslemler);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Cari");
        }

        private bool UrunExists(int id)
        {
            return _context.Urun.Any(e => e.UrunID == id);
        }
    }
}
