using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LVP_231230862_de01.Models;

namespace LVP_231230862_de01.Controllers
{
    public class LvpcomputersController : Controller
    {
        private readonly LeVanPhong231230862De01Context _context;

        public LvpcomputersController(LeVanPhong231230862De01Context context)
        {
            _context = context;
        }

        // GET: Lvpcomputers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Lvpcomputers.ToListAsync());
        }

        // GET: Lvpcomputers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lvpcomputer = await _context.Lvpcomputers
                .FirstOrDefaultAsync(m => m.LvpcomId == id);
            if (lvpcomputer == null)
            {
                return NotFound();
            }

            return View(lvpcomputer);
        }

        // GET: Lvpcomputers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lvpcomputers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LvpcomId,LvpcomName,LvpcomPrice,LvpcomImage,Lvpcomstatus")] Lvpcomputer lvpcomputer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lvpcomputer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lvpcomputer);
        }

        // GET: Lvpcomputers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lvpcomputer = await _context.Lvpcomputers.FindAsync(id);
            if (lvpcomputer == null)
            {
                return NotFound();
            }
            return View(lvpcomputer);
        }

        // POST: Lvpcomputers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LvpcomId,LvpcomName,LvpcomPrice,LvpcomImage,Lvpcomstatus")] Lvpcomputer lvpcomputer)
        {
            if (id != lvpcomputer.LvpcomId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lvpcomputer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LvpcomputerExists(lvpcomputer.LvpcomId))
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
            return View(lvpcomputer);
        }

        // GET: Lvpcomputers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lvpcomputer = await _context.Lvpcomputers
                .FirstOrDefaultAsync(m => m.LvpcomId == id);
            if (lvpcomputer == null)
            {
                return NotFound();
            }

            return View(lvpcomputer);
        }

        // POST: Lvpcomputers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lvpcomputer = await _context.Lvpcomputers.FindAsync(id);
            if (lvpcomputer != null)
            {
                _context.Lvpcomputers.Remove(lvpcomputer);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LvpcomputerExists(int id)
        {
            return _context.Lvpcomputers.Any(e => e.LvpcomId == id);
        }
    }
}
