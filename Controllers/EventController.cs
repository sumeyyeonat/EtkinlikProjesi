using Microsoft.AspNetCore.Mvc;
using EtkinlikSistemi.Data;
using EtkinlikSistemi.Models;
using Microsoft.EntityFrameworkCore;

namespace EtkinlikSistemi.Controllers
{
    public class EventController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Constructor (Yapıcı Metot): Veritabanı bağlantısını buraya enjekte ediyoruz.
        public EventController(ApplicationDbContext context)
        {
            _context = context;
        }

        // 1. LİSTELEME: Tüm etkinlikleri veritabanından çeker ve ekrana gönderir.
        public async Task<IActionResult> Index()
        {
            var etkinlikler = await _context.Events.ToListAsync();
            return View(etkinlikler);
        }

        // 2. EKLEME SAYFASI: Sadece boş bir sayfa (form) gösterir.
        public IActionResult Create()
        {
            return View();
        }

        // 3. KAYDETME: Formdan gelen verileri veritabanına kaydeder.
        [HttpPost]
        public async Task<IActionResult> Create(Event model)
        {
            if (ModelState.IsValid)
            {
                _context.Add(model);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
    
        // 4. DETAY: Belirli bir etkinliğin tüm bilgilerini gösterir.
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var etkinlik = await _context.Events.FirstOrDefaultAsync(m => m.Id == id);
            
            if (etkinlik == null) return NotFound();

            return View(etkinlik);
        }

        // 5. SİLME: Veritabanından veriyi kaldırır.
        public async Task<IActionResult> Delete(int id)
        {
            var etkinlik = await _context.Events.FindAsync(id);
            if (etkinlik != null)
            {
                _context.Events.Remove(etkinlik);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
    }

        // 6. GÜNCELLEME SAYFASI (GET): Eski verileri forma yükler.
public async Task<IActionResult> Edit(int? id)
{
    if (id == null) return NotFound();

    var etkinlik = await _context.Events.FindAsync(id);
    if (etkinlik == null) return NotFound();

    return View(etkinlik);
}

// 7. GÜNCELLEME KAYIT (POST): Değişiklikleri veritabanına işler.
[HttpPost]
public async Task<IActionResult> Edit(int id, Event model)
{
    if (id != model.Id) return NotFound();

    if (ModelState.IsValid)
    {
        _context.Update(model);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    return View(model);
}
    }}