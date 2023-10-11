using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Luksus.Data;
using Luksus.Models;

namespace Luksus.Controllers
{
    public class PerfumesController : Controller
    {
        private readonly LuksusContext _context;

        public PerfumesController(LuksusContext context)
        {
            _context = context;
        }

        // GET: Perfumes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Perfume.ToListAsync());
        }

        // GET: Perfumes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perfume = await _context.Perfume
                .FirstOrDefaultAsync(m => m.Id == id);
            if (perfume == null)
            {
                return NotFound();
            }

            return View(perfume);
        }

        // GET: Perfumes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Perfumes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Brand,Price,FragranceFamily,Volume,Concentration,Rating")] Perfume perfume)
        {
            if (ModelState.IsValid)
            {
                _context.Add(perfume);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(perfume);
        }

        // GET: Perfumes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perfume = await _context.Perfume.FindAsync(id);
            if (perfume == null)
            {
                return NotFound();
            }
            return View(perfume);
        }

        // POST: Perfumes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Brand,Price,FragranceFamily,Volume,Concentration,Rating")] Perfume perfume)
        {
            if (id != perfume.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(perfume);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PerfumeExists(perfume.Id))
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
            return View(perfume);
        }

        // GET: Perfumes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perfume = await _context.Perfume
                .FirstOrDefaultAsync(m => m.Id == id);
            if (perfume == null)
            {
                return NotFound();
            }

            return View(perfume);
        }

        // POST: Perfumes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var perfume = await _context.Perfume.FindAsync(id);
            _context.Perfume.Remove(perfume);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PerfumeExists(int id)
        {
            return _context.Perfume.Any(e => e.Id == id);
        }
    }
}
