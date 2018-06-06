using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BlogUi.Ef;
using BlogUi.Models;

namespace BlogUi.Controllers
{
    public class CountryCodesController : Controller
    {
        private readonly DataContext _context;

        public CountryCodesController(DataContext context)
        {
            _context = context;
        }

        // GET: CountryCodes
        public async Task<IActionResult> Index()
        {
            return View(await _context.CountryCodes.ToListAsync());
        }

        // GET: CountryCodes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var countryCode = await _context.CountryCodes
                .SingleOrDefaultAsync(m => m.ctryId == id);
            if (countryCode == null)
            {
                return NotFound();
            }

            return View(countryCode);
        }

        // GET: CountryCodes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CountryCodes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ctryId,ctryCode,ctryNm")] CountryCode countryCode)
        {
            if (ModelState.IsValid)
            {
                _context.Add(countryCode);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(countryCode);
        }

        // GET: CountryCodes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var countryCode = await _context.CountryCodes.SingleOrDefaultAsync(m => m.ctryId == id);
            if (countryCode == null)
            {
                return NotFound();
            }
            return View(countryCode);
        }

        // POST: CountryCodes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ctryId,ctryCode,ctryNm")] CountryCode countryCode)
        {
            if (id != countryCode.ctryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(countryCode);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CountryCodeExists(countryCode.ctryId))
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
            return View(countryCode);
        }

        // GET: CountryCodes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var countryCode = await _context.CountryCodes
                .SingleOrDefaultAsync(m => m.ctryId == id);
            if (countryCode == null)
            {
                return NotFound();
            }

            return View(countryCode);
        }

        // POST: CountryCodes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var countryCode = await _context.CountryCodes.SingleOrDefaultAsync(m => m.ctryId == id);
            _context.CountryCodes.Remove(countryCode);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CountryCodeExists(int id)
        {
            return _context.CountryCodes.Any(e => e.ctryId == id);
        }
    }
}
