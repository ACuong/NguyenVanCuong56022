using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenVanCuong56022;

namespace NguyenVanCuong56022.Controllers
{
    public class NVC056022Controller : Controller
    {
        private readonly ApplicationDBContext _context;

        public NVC056022Controller(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: NVC056022
        public async Task<IActionResult> Index()
        {
            return View(await _context.NVC056022.ToListAsync());
        }

        // GET: NVC056022/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nVC056022 = await _context.NVC056022
                .FirstOrDefaultAsync(m => m.NVCID == id);
            if (nVC056022 == null)
            {
                return NotFound();
            }

            return View(nVC056022);
        }

        // GET: NVC056022/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NVC056022/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NVCID,NVCName,NVCGender")] NVC056022 nVC056022)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nVC056022);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nVC056022);
        }

        // GET: NVC056022/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nVC056022 = await _context.NVC056022.FindAsync(id);
            if (nVC056022 == null)
            {
                return NotFound();
            }
            return View(nVC056022);
        }

        // POST: NVC056022/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NVCID,NVCName,NVCGender")] NVC056022 nVC056022)
        {
            if (id != nVC056022.NVCID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nVC056022);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NVC056022Exists(nVC056022.NVCID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(nVC056022);
        }

        // GET: NVC056022/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nVC056022 = await _context.NVC056022
                .FirstOrDefaultAsync(m => m.NVCID == id);
            if (nVC056022 == null)
            {
                return NotFound();
            }

            return View(nVC056022);
        }

        // POST: NVC056022/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nVC056022 = await _context.NVC056022.FindAsync(id);
            _context.NVC056022.Remove(nVC056022);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NVC056022Exists(string id)
        {
            return _context.NVC056022.Any(e => e.NVCID == id);
        }
    }
}
