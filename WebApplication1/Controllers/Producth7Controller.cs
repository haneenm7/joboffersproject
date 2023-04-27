using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Producth7Controller : Controller
    {
        private readonly ModelContext _context;

        public Producth7Controller(ModelContext context)
        {
            _context = context;
        }

        // GET: Producth7
        public async Task<IActionResult> Index()
        {
            var modelContext = _context.Producth7s.Include(p => p.Category);
            return View(await modelContext.ToListAsync());
        }

        // GET: Producth7/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producth7 = await _context.Producth7s
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producth7 == null)
            {
                return NotFound();
            }

            return View(producth7);
        }

        // GET: Producth7/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categoryh7s, "Id", "Id");
            return View();
        }

        // POST: Producth7/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Sale,Price,CategoryId")] Producth7 producth7)
        {
            if (ModelState.IsValid)
            {
                _context.Add(producth7);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categoryh7s, "Id", "Id", producth7.CategoryId);
            return View(producth7);
        }

        // GET: Producth7/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producth7 = await _context.Producth7s.FindAsync(id);
            if (producth7 == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categoryh7s, "Id", "Id", producth7.CategoryId);
            return View(producth7);
        }

        // POST: Producth7/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("Id,Name,Sale,Price,CategoryId")] Producth7 producth7)
        {
            if (id != producth7.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producth7);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Producth7Exists(producth7.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.Categoryh7s, "Id", "Id", producth7.CategoryId);
            return View(producth7);
        }

        // GET: Producth7/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producth7 = await _context.Producth7s
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producth7 == null)
            {
                return NotFound();
            }

            return View(producth7);
        }

        // POST: Producth7/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var producth7 = await _context.Producth7s.FindAsync(id);
            _context.Producth7s.Remove(producth7);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Producth7Exists(decimal id)
        {
            return _context.Producth7s.Any(e => e.Id == id);
        }
    }
}
