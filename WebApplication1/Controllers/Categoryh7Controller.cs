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
    public class Categoryh7Controller : Controller
    {
        private readonly ModelContext _context;

        public Categoryh7Controller(ModelContext context)
        {
            _context = context;
        }

        // GET: Categoryh7
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categoryh7s.ToListAsync());
        }

        // GET: Categoryh7/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryh7 = await _context.Categoryh7s
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categoryh7 == null)
            {
                return NotFound();
            }

            return View(categoryh7);
        }

        // GET: Categoryh7/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categoryh7/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CategoryName,ImagePath")] Categoryh7 categoryh7)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoryh7);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categoryh7);
        }

        // GET: Categoryh7/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryh7 = await _context.Categoryh7s.FindAsync(id);
            if (categoryh7 == null)
            {
                return NotFound();
            }
            return View(categoryh7);
        }

        // POST: Categoryh7/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("Id,CategoryName,ImagePath")] Categoryh7 categoryh7)
        {
            if (id != categoryh7.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categoryh7);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Categoryh7Exists(categoryh7.Id))
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
            return View(categoryh7);
        }

        // GET: Categoryh7/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryh7 = await _context.Categoryh7s
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categoryh7 == null)
            {
                return NotFound();
            }

            return View(categoryh7);
        }

        // POST: Categoryh7/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var categoryh7 = await _context.Categoryh7s.FindAsync(id);
            _context.Categoryh7s.Remove(categoryh7);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Categoryh7Exists(decimal id)
        {
            return _context.Categoryh7s.Any(e => e.Id == id);
        }
    }
}
