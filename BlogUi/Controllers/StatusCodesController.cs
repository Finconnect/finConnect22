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
    public class StatusCodesController : Controller
    {
        private readonly DataContext _context;

        public StatusCodesController(DataContext context)
        {
            _context = context;
        }

        // GET: StatusCodes
        public async Task<IActionResult> Index()
        {
            return View(await _context.statusCodes.ToListAsync());
        }

        // GET: StatusCodes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statusCode = await _context.statusCodes
                .SingleOrDefaultAsync(m => m.stsCodeId == id);
            if (statusCode == null)
            {
                return NotFound();
            }

            return View(statusCode);
        }

        // GET: StatusCodes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StatusCodes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("stsCodeId,stsCode,stsName,stsDesc")] StatusCode statusCode)
        {
            if (ModelState.IsValid)
            {
                _context.Add(statusCode);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(statusCode);
        }

        // GET: StatusCodes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statusCode = await _context.statusCodes.SingleOrDefaultAsync(m => m.stsCodeId == id);
            if (statusCode == null)
            {
                return NotFound();
            }
            return View(statusCode);
        }

        // POST: StatusCodes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("stsCodeId,stsCode,stsName,stsDesc")] StatusCode statusCode)
        {
            if (id != statusCode.stsCodeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(statusCode);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StatusCodeExists(statusCode.stsCodeId))
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
            return View(statusCode);
        }

        // GET: StatusCodes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statusCode = await _context.statusCodes
                .SingleOrDefaultAsync(m => m.stsCodeId == id);
            if (statusCode == null)
            {
                return NotFound();
            }

            return View(statusCode);
        }

        // POST: StatusCodes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var statusCode = await _context.statusCodes.SingleOrDefaultAsync(m => m.stsCodeId == id);
            _context.statusCodes.Remove(statusCode);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StatusCodeExists(int id)
        {
            return _context.statusCodes.Any(e => e.stsCodeId == id);
        }
    }
}
