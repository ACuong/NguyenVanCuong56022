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
    public class UniversityNVC56022Controller : Controller
    {
        private readonly ApplicationDBContext _context;

        public UniversityNVC56022Controller(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: UniversityNVC56022
        public async Task<IActionResult> Index()
        {
            return View(await _context.UniversityNVC56022.ToListAsync());
        }

        // GET: UniversityNVC56022/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityNVC56022 = await _context.UniversityNVC56022
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityNVC56022 == null)
            {
                return NotFound();
            }

            return View(universityNVC56022);
        }

        // GET: UniversityNVC56022/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UniversityNVC56022/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UniversityId,UniversityName")] UniversityNVC56022 universityNVC56022)
        {
            if (ModelState.IsValid)
            {
                _context.Add(universityNVC56022);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(universityNVC56022);
        }

        // GET: UniversityNVC56022/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityNVC56022 = await _context.UniversityNVC56022.FindAsync(id);
            if (universityNVC56022 == null)
            {
                return NotFound();
            }
            return View(universityNVC56022);
        }

        // POST: UniversityNVC56022/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UniversityId,UniversityName")] UniversityNVC56022 universityNVC56022)
        {
            if (id != universityNVC56022.UniversityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(universityNVC56022);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UniversityNVC56022Exists(universityNVC56022.UniversityId))
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
            return View(universityNVC56022);
        }

        // GET: UniversityNVC56022/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityNVC56022 = await _context.UniversityNVC56022
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityNVC56022 == null)
            {
                return NotFound();
            }

            return View(universityNVC56022);
        }

        // POST: UniversityNVC56022/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var universityNVC56022 = await _context.UniversityNVC56022.FindAsync(id);
            _context.UniversityNVC56022.Remove(universityNVC56022);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UniversityNVC56022Exists(string id)
        {
            return _context.UniversityNVC56022.Any(e => e.UniversityId == id);
        }
    }
}
