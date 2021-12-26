using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using G191210046.Data;
using G191210046.Models;
using Microsoft.AspNetCore.Authorization;

namespace G191210046.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class DukkanController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DukkanController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Dukkan
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dukkan.ToListAsync());
        }

        // GET: Admin/Dukkan/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dukkan = await _context.Dukkan
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dukkan == null)
            {
                return NotFound();
            }

            return View(dukkan);
        }

        // GET: Admin/Dukkan/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Dukkan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ad,Adres,TelNo,Aciklama")] Dukkan dukkan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dukkan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dukkan);
        }

        // GET: Admin/Dukkan/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dukkan = await _context.Dukkan.FindAsync(id);
            if (dukkan == null)
            {
                return NotFound();
            }
            return View(dukkan);
        }

        // POST: Admin/Dukkan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ad,Adres,TelNo,Aciklama")] Dukkan dukkan)
        {
            if (id != dukkan.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dukkan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DukkanExists(dukkan.Id))
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
            return View(dukkan);
        }

        // GET: Admin/Dukkan/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dukkan = await _context.Dukkan
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dukkan == null)
            {
                return NotFound();
            }

            return View(dukkan);
        }

        // POST: Admin/Dukkan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dukkan = await _context.Dukkan.FindAsync(id);
            _context.Dukkan.Remove(dukkan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DukkanExists(int id)
        {
            return _context.Dukkan.Any(e => e.Id == id);
        }
    }
}
