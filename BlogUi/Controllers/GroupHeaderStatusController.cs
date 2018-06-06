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
    public class GroupHeaderStatusController : Controller
    {
        private readonly DataContext _context;

        public GroupHeaderStatusController(DataContext context)
        {
            _context = context;
        }

        // GET: GroupHeaderStatus
        public async Task<IActionResult> Index()
        {
            return View(await _context.groupHeaderStatuses.ToListAsync());
        }

        // GET: GroupHeaderStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupHeaderStatus = await _context.groupHeaderStatuses
                .SingleOrDefaultAsync(m => m.grpHStsId == id);
            if (groupHeaderStatus == null)
            {
                return NotFound();
            }

            return View(groupHeaderStatus);
        }

        // GET: GroupHeaderStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GroupHeaderStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("grpHStsId,msgId,creDtTm")] GroupHeaderStatus groupHeaderStatus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(groupHeaderStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(groupHeaderStatus);
        }

        // GET: GroupHeaderStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupHeaderStatus = await _context.groupHeaderStatuses.SingleOrDefaultAsync(m => m.grpHStsId == id);
            if (groupHeaderStatus == null)
            {
                return NotFound();
            }
            return View(groupHeaderStatus);
        }

        // POST: GroupHeaderStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("grpHStsId,msgId,creDtTm")] GroupHeaderStatus groupHeaderStatus)
        {
            if (id != groupHeaderStatus.grpHStsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(groupHeaderStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GroupHeaderStatusExists(groupHeaderStatus.grpHStsId))
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
            return View(groupHeaderStatus);
        }

        // GET: GroupHeaderStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupHeaderStatus = await _context.groupHeaderStatuses
                .SingleOrDefaultAsync(m => m.grpHStsId == id);
            if (groupHeaderStatus == null)
            {
                return NotFound();
            }

            return View(groupHeaderStatus);
        }

        // POST: GroupHeaderStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var groupHeaderStatus = await _context.groupHeaderStatuses.SingleOrDefaultAsync(m => m.grpHStsId == id);
            _context.groupHeaderStatuses.Remove(groupHeaderStatus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroupHeaderStatusExists(int id)
        {
            return _context.groupHeaderStatuses.Any(e => e.grpHStsId == id);
        }
    }
}
