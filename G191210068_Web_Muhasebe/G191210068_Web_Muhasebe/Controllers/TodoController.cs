using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using G191210068_Web_Muhasebe.Models;
using G191210068_Web_Muhasebe.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G191210068_Web_Muhasebe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {

        private readonly MuhasebeDbContext _context;

        public TodoController(MuhasebeDbContext context)
        {
            _context = context;
        }

        // GET: api/Todo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cari>>> GetTodoItems()
        {
            return await _context.Cari.ToListAsync();
        }

        // GET: api/Todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cari>> GetTodoItem(long id)
        {
            var todoItem = await _context.Cari.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }

        [HttpPost]
        public void Post([FromBody] Cari cari)
        {
            _context.Cari.Add(cari);
            _context.SaveChanges();
        }

        // PUT api/<CategoriesApiController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Cari cari)
        {
            var bulunan = _context.Cari.FirstOrDefault(x => x.CariID == id);

            if (bulunan is null)
            {
                return NotFound();
            }
            else
            {
                bulunan.Aciklama = cari.Aciklama;
                bulunan.Adres = cari.Adres;
                bulunan.Bakiye = cari.Bakiye;
                bulunan.Email = cari.Email;
                bulunan.Fax = cari.Fax;
                bulunan.FirmaAdi = cari.FirmaAdi;
                bulunan.Grup = cari.Grup;
                bulunan.Il = cari.Il;
                bulunan.Ilçe = cari.Ilçe;
                bulunan.PostaKodu = cari.PostaKodu;
                bulunan.SevkAdresi = cari.SevkAdresi;
                bulunan.Telefon = cari.Telefon;
                bulunan.Yetkili = cari.Yetkili;
                bulunan.ToplamAlacak = bulunan.ToplamAlacak;
                bulunan.ToplamBorc = bulunan.ToplamBorc;
                bulunan.User = bulunan.User;
                bulunan.UserId = bulunan.UserId;
                _context.Update(bulunan);
                _context.SaveChanges();
                return Ok();
            }
        }

        // DELETE api/<CategoriesApiController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var bulunan = _context.Cari.FirstOrDefault(x => x.CariID == id);

            if (bulunan is null)
            {
                return NotFound();
            }
            else
            {
                _context.Remove(bulunan);
                _context.SaveChanges();
                return Ok();
            }
        }

    }
}
