using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SCAF.Data;
using SCAF.Models;
using SCAF.Data;
using SCAF.Models;
using System.Threading.Tasks;

namespace SCAF_3b.Controllers
{
    public class PadresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PadresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Padres
        public async Task<IActionResult> Index()
        {
            var padres = await _context.Padres.ToListAsync();
            return View(padres);
        }

        // GET: /Padres/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Padres/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Padre padre)
        {
            if (ModelState.IsValid)
            {
                _context.Add(padre);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(padre);
        }

        // GET: /Padres/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var padre = await _context.Padres.FindAsync(id);
            if (padre == null) return NotFound();
            return View(padre);
        }

        // POST: /Padres/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Padre padre)
        {
            if (id != padre.IdPadre) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(padre);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(padre);
        }

        // GET: /Padres/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var padre = await _context.Padres.FirstOrDefaultAsync(p => p.IdPadre == id);
            if (padre == null) return NotFound();
            return View(padre);
        }

        // POST: /Padres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var padre = await _context.Padres.FindAsync(id);
            _context.Padres.Remove(padre);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
