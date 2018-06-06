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
    public class ReasonCodesController : Controller
    {
        private readonly DataContext _context;

        public ReasonCodesController(DataContext context)
        {
            _context = context;
        }

        // GET: ReasonCodes
        public async Task<IActionResult> Index()
        {
            return View(await _context.reasonCodes.ToListAsync());
        }

        // GET: ReasonCodes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reasonCode = await _context.reasonCodes
                .SingleOrDefaultAsync(m => m.rsnId == id);
            if (reasonCode == null)
            {
                return NotFound();
            }

            return View(reasonCode);
        }

        // GET: ReasonCodes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReasonCodes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("rsnId,rsnNm,rsnDesc")] ReasonCode reasonCode)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reasonCode);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reasonCode);
        }

        // GET: ReasonCodes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reasonCode = await _context.reasonCodes.SingleOrDefaultAsync(m => m.rsnId == id);
            if (reasonCode == null)
            {
                return NotFound();
            }
            return View(reasonCode);
        }

        // POST: ReasonCodes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("rsnId,rsnNm,rsnDesc")] ReasonCode reasonCode)
        {
            if (id != reasonCode.rsnId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reasonCode);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReasonCodeExists(reasonCode.rsnId))
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
            return View(reasonCode);
        }

        // GET: ReasonCodes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reasonCode = await _context.reasonCodes
                .SingleOrDefaultAsync(m => m.rsnId == id);
            if (reasonCode == null)
            {
                return NotFound();
            }

            return View(reasonCode);
        }

        // POST: ReasonCodes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reasonCode = await _context.reasonCodes.SingleOrDefaultAsync(m => m.rsnId == id);
            _context.reasonCodes.Remove(reasonCode);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReasonCodeExists(int id)
        {
            return _context.reasonCodes.Any(e => e.rsnId == id);
        }
    }
}
