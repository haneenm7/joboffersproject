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
    public class UserLoginh7Controller : Controller
    {
        private readonly ModelContext _context;

        public UserLoginh7Controller(ModelContext context)
        {
            _context = context;
        }

        // GET: UserLoginh7
        public async Task<IActionResult> Index()
        {
            var modelContext = _context.UserLoginh7s.Include(u => u.Customer).Include(u => u.Role);
            return View(await modelContext.ToListAsync());
        }

        // GET: UserLoginh7/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userLoginh7 = await _context.UserLoginh7s
                .Include(u => u.Customer)
                .Include(u => u.Role)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userLoginh7 == null)
            {
                return NotFound();
            }

            return View(userLoginh7);
        }

        // GET: UserLoginh7/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customerh7s, "Id", "Id");
            ViewData["RoleId"] = new SelectList(_context.Rolesh7s, "Id", "Id");
            return View();
        }

        // POST: UserLoginh7/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName,Password,RoleId,CustomerId")] UserLoginh7 userLoginh7)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userLoginh7);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customerh7s, "Id", "Id", userLoginh7.CustomerId);
            ViewData["RoleId"] = new SelectList(_context.Rolesh7s, "Id", "Id", userLoginh7.RoleId);
            return View(userLoginh7);
        }

        // GET: UserLoginh7/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userLoginh7 = await _context.UserLoginh7s.FindAsync(id);
            if (userLoginh7 == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customerh7s, "Id", "Id", userLoginh7.CustomerId);
            ViewData["RoleId"] = new SelectList(_context.Rolesh7s, "Id", "Id", userLoginh7.RoleId);
            return View(userLoginh7);
        }

        // POST: UserLoginh7/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("Id,UserName,Password,RoleId,CustomerId")] UserLoginh7 userLoginh7)
        {
            if (id != userLoginh7.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userLoginh7);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserLoginh7Exists(userLoginh7.Id))
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
            ViewData["CustomerId"] = new SelectList(_context.Customerh7s, "Id", "Id", userLoginh7.CustomerId);
            ViewData["RoleId"] = new SelectList(_context.Rolesh7s, "Id", "Id", userLoginh7.RoleId);
            return View(userLoginh7);
        }

        // GET: UserLoginh7/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userLoginh7 = await _context.UserLoginh7s
                .Include(u => u.Customer)
                .Include(u => u.Role)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userLoginh7 == null)
            {
                return NotFound();
            }

            return View(userLoginh7);
        }

        // POST: UserLoginh7/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var userLoginh7 = await _context.UserLoginh7s.FindAsync(id);
            _context.UserLoginh7s.Remove(userLoginh7);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserLoginh7Exists(decimal id)
        {
            return _context.UserLoginh7s.Any(e => e.Id == id);
        }
    }
}
