using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using G191210068_Web_Muhasebe.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using G191210068_Web_Muhasebe.Models.Data;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace G191210068_Web_Muhasebe.Controllers
{
    [Authorize(Roles="User")]
    public class HomeController : Controller
    {
        private readonly MuhasebeDbContext _context;
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor httpContextAccessor, MuhasebeDbContext context)
        {
            _context = context;
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IActionResult> Index()
        {
            if(_httpContextAccessor.HttpContext.User.IsInRole("Administrator"))
                return RedirectToAction("Index", "Admin");

           
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);//id
            var cariler = await _context.Cari.Include(x => x.User).Where(y => y.UserId == userId).OrderByDescending(z => z.CariID).ToListAsync();

            ViewBag.ToplamAlacak = cariler.Sum(x => x.ToplamAlacak);
            ViewBag.ToplamBorc = cariler.Sum(x => x.ToplamBorc);
            ViewBag.Bakiye = ViewBag.ToplamBorc - ViewBag.ToplamAlacak;
            ViewBag.VadeliIslemler = _context.CariIslemler.Where(x => x.odemeSekli == OdemeSekli.Açıktan).ToList();

            return View(cariler);
        }

        public ActionResult OnGetChartData()
        {
            var cariler = _context.Cari.ToList();
            return Json(cariler);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ChangeLanguage(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions() { Expires = DateTimeOffset.UtcNow.AddYears(1) });

            return Redirect(Request.Headers["Referer"].ToString());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
