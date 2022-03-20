using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using G191210068_Web_Muhasebe.Models;
using G191210068_Web_Muhasebe.Models.Data;
using System.Diagnostics;
using System.Security;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.IdentityModel.Protocols;
using MimeKit;
using System.Net.Mail;
using System.Net;
using System.Threading;
using Rotativa.AspNetCore;

namespace G191210068_Web_Muhasebe.Controllers
{
    [Authorize(Roles = "User")]
    public class CariController : Controller
    {
        private readonly MuhasebeDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CariController(MuhasebeDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: Cari
        public async Task<IActionResult> Index()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);//id
            var cariler = await _context.Cari.Include(x => x.User).Where(y => y.UserId == userId).OrderByDescending(z=>z.CariID).ToListAsync();
            foreach (var item in cariler)
            {
                var CariToplamAlacak = _context.CariIslemler.Include(x => x.Cari).Where(y => y.CariId == item.CariID).Select(z => z.Alacak).Sum();
                var CariToplamBorc = _context.CariIslemler.Include(x => x.Cari).Where(y => y.CariId == item.CariID).Select(z => z.Borc).Sum();
                item.ToplamAlacak = CariToplamAlacak;
                item.ToplamBorc = CariToplamBorc;
                item.Bakiye = item.ToplamBorc - item.ToplamAlacak;
            }
            await _context.SaveChangesAsync();
            return View(cariler);
        }

        // GET: Cari/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Cari");
                //return NotFound();
            }

            var cari = await _context.Cari.FirstOrDefaultAsync(m => m.CariID == id);
            var CariToplamAlacak = _context.CariIslemler.Include(x => x.Cari).Where(y => y.CariId == cari.CariID).Select(z => z.Alacak).Sum();
            var CariToplamBorc = _context.CariIslemler.Include(x => x.Cari).Where(y => y.CariId == cari.CariID).Select(z => z.Borc).Sum();
            cari.ToplamAlacak = CariToplamAlacak;
            cari.ToplamBorc = CariToplamBorc;

            if (cari == null)
            {
                return NotFound();
            }

            return View(cari);
        }

        // GET: Cari/Create
        public IActionResult Create()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            //var user = _httpContextAccessor.HttpContext.User;
            ViewBag.userId = userId;
            return View();
        }

        // POST: Cari/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CariID,FirmaAdi,Yetkili,Telefon,Fax,İl,İlçe,Adres,Email,SevkAdresi,PostaKodu,Aciklama,Borc,Alacak,Grup,UserId")] Cari cari)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cari);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cari);
        }

        // GET: Cari/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);//id
            if (id == null)
            {
                return RedirectToAction("Index", "Cari");
                //return NotFound();
            }

            var cari = await _context.Cari.FindAsync(id);
            if (cari == null)
            {
                return NotFound();
            }
            return View(cari);
        }

        // POST: Cari/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CariID,FirmaAdi,Yetkili,Telefon,Fax,İl,İlçe,Adres,Email,SevkAdresi,PostaKodu,Aciklama,Borc,Alacak,Grup,UserId")] Cari cari)
        {
            if (id != cari.CariID)
            {
                return RedirectToAction("Index", "Cari");
                //return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cari);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CariExists(cari.CariID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(cari);
        }

        // GET: Cari/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Cari");
                //return NotFound();
            }

            var cari = await _context.Cari
                .FirstOrDefaultAsync(m => m.CariID == id);
            if (cari == null)
            {
                return NotFound();
            }

            return View(cari);
        }
        // POST: Cari/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cari = await _context.Cari.FindAsync(id);

            var cari_Islemler = _context.CariIslemler.Include(p => p.Cari).Where(x => x.CariId == cari.CariID).ToList();
            foreach (var item in cari_Islemler)
            {
                var cariIslemler_urun = _context.Urun.Include(p => p.CariIslemler).Where(x => x.IslemID == item.CariIslemlerID).ToList();
                foreach (var item2 in cariIslemler_urun)
                {
                    _context.Urun.Remove(item2);
                }
                _context.CariIslemler.Remove(item);
            }
            _context.Cari.Remove(cari);
           
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> CariSec(IslemTuru islemTuru)
        {
            ViewBag.islemTuru = islemTuru;
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);//id
            var cariler = await _context.Cari.Include(x => x.User).Where(y => y.UserId == userId).OrderByDescending(z => z.CariID).ToListAsync();
            foreach (var item in cariler)
            {
                var CariToplamAlacak = _context.CariIslemler.Include(x => x.Cari).Where(y => y.CariId == item.CariID).Select(z => z.Alacak).Sum();
                var CariToplamBorc = _context.CariIslemler.Include(x => x.Cari).Where(y => y.CariId == item.CariID).Select(z => z.Borc).Sum();
                item.ToplamAlacak = CariToplamAlacak;
                item.ToplamBorc = CariToplamBorc;
            }
            await _context.SaveChangesAsync();

            return View(cariler);
        }
        private bool CariExists(int id)
        {
            return _context.Cari.Any(e => e.CariID == id);
        }


        [HttpGet]
        public IActionResult TarihSec(string PdfId,int id)
        {
            ViewBag.PdfId = PdfId;
            ViewBag.id = id;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> TarihSec(string PdfId, int id,[Bind("IlkFaturaTarihi,SonFaturaTarihi")] TarihSec tarihsec)
        {
            if(PdfId=="1")
                return RedirectToAction("AllCariIslemlerPdf", new { tarih_ilk = tarihsec.IlkFaturaTarihi, tarih_son= tarihsec.SonFaturaTarihi});

            if (PdfId == "2")
                return RedirectToAction("GetAll", new {id=id, tarih_ilk = tarihsec.IlkFaturaTarihi, tarih_son = tarihsec.SonFaturaTarihi });

            if (PdfId == "3")
                return RedirectToAction("AllCari_CariIslemlerPdf", new {tarih_ilk = tarihsec.IlkFaturaTarihi, tarih_son = tarihsec.SonFaturaTarihi });

            return RedirectToAction("TarihSec", new { PdfId = PdfId });
        }

        public IActionResult AllCariIslemlerPdf(DateTime tarih_ilk,DateTime tarih_son)
        {
            ViewBag.ToplamAlacak = _context.Cari.Sum(x => x.ToplamAlacak);
            ViewBag.ToplamBorc = _context.Cari.Sum(x => x.ToplamBorc);
            ViewBag.Bakiye = ViewBag.ToplamBorc - ViewBag.ToplamAlacak;

            var cariler = _context.Cari.ToList();
            var carilerIslemler = _context.CariIslemler.Where(x=>x.FaturaTarihi>=tarih_ilk && x.FaturaTarihi<=tarih_son).OrderByDescending(z => z.FaturaTarihi).ThenByDescending(t=>t.Saat).ToList();
            var model = from s in carilerIslemler
                        join st in cariler on s.CariId equals st.CariID into st2
                        from st in st2.DefaultIfEmpty()
                        select new VadeliIslemler { CariIslemler = s, Cari = st };

            var pdf = new ViewAsPdf(model, ViewData)
            {

            };
            return pdf;
        }
        public IActionResult AllCari_CariIslemlerPdf(DateTime tarih_ilk, DateTime tarih_son)
        {
            ViewBag.ToplamAlacak = _context.Cari.Sum(x => x.ToplamAlacak);
            ViewBag.ToplamBorc = _context.Cari.Sum(x => x.ToplamBorc);
            ViewBag.Bakiye = ViewBag.ToplamBorc - ViewBag.ToplamAlacak;
            var urunler = _context.Urun.ToList();

            var cariler = _context.Cari.ToList();
            var carilerIslemler = _context.CariIslemler.Where(x => x.FaturaTarihi >= tarih_ilk && x.FaturaTarihi <= tarih_son).OrderByDescending(z => z.FaturaTarihi).ThenByDescending(t => t.Saat).ToList();
            var model = from s in carilerIslemler
                        join st in cariler on s.CariId equals st.CariID into st2
                        join st3 in urunler on s.CariIslemlerID equals st3.IslemID into st4
                        from st in st2.DefaultIfEmpty()
                        from st3 in st4.DefaultIfEmpty()

                        select new TumCari_Islemler { CariIslemler = s, Cari = st,Urun=st3 };

            var pdf = new ViewAsPdf(model, ViewData)
            {

            };
            return pdf;
        }
        public IActionResult GetAll(int id, DateTime tarih_ilk, DateTime tarih_son)//pdf
        {
            var CariToplamAlacak = _context.CariIslemler.Include(x => x.Cari).Where(y => y.CariId == id).Select(z => z.Alacak).Sum();
            var CariToplamBorc = _context.CariIslemler.Include(x => x.Cari).Where(y => y.CariId == id).Select(z => z.Borc).Sum();

            var cariAd = _context.Cari.FirstOrDefault(x => x.CariID == id).FirmaAdi;
            var grup = _context.Cari.FirstOrDefault(x => x.CariID == id).Grup;
            var yetkili = _context.Cari.FirstOrDefault(x => x.CariID == id).Yetkili;

            ViewBag.CariAd = cariAd;
            ViewBag.Grup = grup;
            ViewBag.Yetkili = yetkili;
            ViewBag.CariToplamBorc = CariToplamBorc;
            ViewBag.CariToplamAlacak = CariToplamAlacak;

            var carilerIslemler = _context.CariIslemler.Where(x => x.FaturaTarihi >= tarih_ilk && x.FaturaTarihi <= tarih_son).Where(x => x.CariId == id).OrderByDescending(z => z.FaturaTarihi).ThenByDescending(t => t.Saat).ToList();
            //var AllCari_CariIslemler = _context.CariIslemler.Where(x => x.CariId == id).OrderByDescending(z => z.CariIslemlerID).ToList();
            var urunler = _context.Urun.ToList();

            var model = from s in carilerIslemler
                        join st in urunler on s.CariIslemlerID equals st.IslemID into st2
                        from st in st2.DefaultIfEmpty()
                        select new PdfClass { CariIslemler = s, Urun = st };

            var pdf = new ViewAsPdf(model, ViewData)
            {

            };
            return pdf;
        }
        public IActionResult AllCariPdf()
        {
            ViewBag.ToplamAlacak = _context.Cari.Sum(x => x.ToplamAlacak);
            ViewBag.ToplamBorc = _context.Cari.Sum(x => x.ToplamBorc);
            ViewBag.Bakiye = ViewBag.ToplamBorc - ViewBag.ToplamAlacak;

            var cariler = _context.Cari.OrderByDescending(z => z.CariID).ToList();

            var pdf = new ViewAsPdf(cariler, ViewData)
            {

            };
            return pdf;
        }


        public IActionResult Backup()
        {
            this.BackupSQL();
            Thread.Sleep(2000);
            this.SendEmail();
            return RedirectToAction("Index","Home");
        }
        private void BackupSQL()
        {

            var targetURL = "C:\\MuhasebeYedek\\back.bat";
            var psi = new ProcessStartInfo
            {
                FileName = targetURL,
                UseShellExecute = true
            };
            Process.Start(psi);
        }
        private void SendEmail()
        {
            using (MailMessage mm = new MailMessage("***@gmail.com", "***@gmail.com"))
            {

                mm.Subject = "Muhasebe Yedek " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                mm.Body = "***";

                string fileName = "C:\\MuhasebeYedek\\MuhasebeYedek.sql";
                mm.Attachments.Add(new Attachment(fileName));

                mm.IsBodyHtml = false;
                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    //smtp.Host = "smtp.gmail.com";

                    NetworkCredential NetworkCred = new NetworkCredential("***@gmail.com", "***");
                    smtp.Credentials = NetworkCred;
                    smtp.Port = 587;
                    smtp.Send(mm);

                }
            }
        }
    }
}
