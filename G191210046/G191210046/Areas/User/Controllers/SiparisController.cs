﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using G191210046.Data;
using G191210046.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace G191210046.Areas.User.Controllers
{
    [Area("User")]
    [Authorize(Roles = "User")]

    public class SiparisController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SiparisController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: User/Siparis
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Siparis.Include(s => s.ApplicationUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: User/Siparis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var siparis = await _context.Siparis
                .Include(s => s.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (siparis == null)
            {
                return NotFound();
            }

            return View(siparis);
        }

        // GET: User/Siparis/Create
        public IActionResult Create()
        {
            ViewData["MusteriId"] = new SelectList(_context.ApplicationUser, "Id", "Id");
            return View();
        }

        // POST: User/Siparis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormCollection collection)
        {
            var rand = new Random();

            var user = _context.ApplicationUser.Where(x => x.UserName == HttpContext.User.Identity.Name).ToList();
            Siparis siparis = new Siparis();
            siparis.ToplamUcret = rand.Next(100);
            siparis.SiparisDurumu = 0;
            siparis.MusteriId = user[0].Id; ;
            siparis.SiparisTarihi = DateTime.Now;
            siparis.Aciklama = collection["Aciklama"];

            if (ModelState.IsValid)
            {
                _context.Add(siparis);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MusteriId"] = new SelectList(_context.ApplicationUser, "Id", "Id", siparis.MusteriId);
            return View(siparis);
        }

        // GET: User/Siparis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var siparis = await _context.Siparis.FindAsync(id);
            if (siparis == null)
            {
                return NotFound();
            }
            ViewData["MusteriId"] = new SelectList(_context.ApplicationUser, "Id", "Id", siparis.MusteriId);
            return View(siparis);
        }

        // POST: User/Siparis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MusteriId,ToplamUcret,SiparisTarihi,SiparisDurumu,SiparisKodu,Aciklama")] Siparis siparis)
        {
            if (id != siparis.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(siparis);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SiparisExists(siparis.Id))
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
            ViewData["MusteriId"] = new SelectList(_context.ApplicationUser, "Id", "Id", siparis.MusteriId);
            return View(siparis);
        }

        // GET: User/Siparis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var siparis = await _context.Siparis
                .Include(s => s.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (siparis == null)
            {
                return NotFound();
            }

            return View(siparis);
        }

        // POST: User/Siparis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var siparis = await _context.Siparis.FindAsync(id);
            _context.Siparis.Remove(siparis);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SiparisExists(int id)
        {
            return _context.Siparis.Any(e => e.Id == id);
        }
    }
}
