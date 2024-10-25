using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KooliProjekt.Data;

namespace KooliProjekt.Controllers
{
    public class RegisteringsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegisteringsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Registerings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Registering.ToListAsync());
        }

        // GET: Registerings/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registering = await _context.Registering
                .FirstOrDefaultAsync(m => m.ID == id);
            if (registering == null)
            {
                return NotFound();
            }

            return View(registering);
        }

        // GET: Registerings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Registerings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Client_ID,Payment_ID,Date,Event_ID")] Registering registering)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registering);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registering);
        }

        // GET: Registerings/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registering = await _context.Registering.FindAsync(id);
            if (registering == null)
            {
                return NotFound();
            }
            return View(registering);
        }

        // POST: Registerings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Client_ID,Payment_ID,Date,Event_ID")] Registering registering)
        {
            if (id != registering.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registering);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegisteringExists(registering.ID))
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
            return View(registering);
        }

        // GET: Registerings/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registering = await _context.Registering
                .FirstOrDefaultAsync(m => m.ID == id);
            if (registering == null)
            {
                return NotFound();
            }

            return View(registering);
        }

        // POST: Registerings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var registering = await _context.Registering.FindAsync(id);
            if (registering != null)
            {
                _context.Registering.Remove(registering);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegisteringExists(string id)
        {
            return _context.Registering.Any(e => e.ID == id);
        }
    }
}
