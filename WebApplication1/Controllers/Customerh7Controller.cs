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
    public class Customerh7Controller : Controller
    {
        private readonly ModelContext _context;

        public Customerh7Controller(ModelContext context)
        {
            _context = context;
        }

        // GET: Customerh7
        public async Task<IActionResult> Index()
        {
            return View(await _context.Customerh7s.ToListAsync());
        }

        // GET: Customerh7/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerh7 = await _context.Customerh7s
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customerh7 == null)
            {
                return NotFound();
            }

            return View(customerh7);
        }

        // GET: Customerh7/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customerh7/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fname,Lname,ImagePath")] Customerh7 customerh7)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerh7);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customerh7);
        }

        // GET: Customerh7/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerh7 = await _context.Customerh7s.FindAsync(id);
            if (customerh7 == null)
            {
                return NotFound();
            }
            return View(customerh7);
        }

        // POST: Customerh7/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("Id,Fname,Lname,ImagePath")] Customerh7 customerh7)
        {
            if (id != customerh7.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerh7);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Customerh7Exists(customerh7.Id))
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
            return View(customerh7);
        }

        // GET: Customerh7/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerh7 = await _context.Customerh7s
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customerh7 == null)
            {
                return NotFound();
            }

            return View(customerh7);
        }

        // POST: Customerh7/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var customerh7 = await _context.Customerh7s.FindAsync(id);
            _context.Customerh7s.Remove(customerh7);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Customerh7Exists(decimal id)
        {
            return _context.Customerh7s.Any(e => e.Id == id);
        }
    }
}
