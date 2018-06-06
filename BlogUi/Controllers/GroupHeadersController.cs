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
    public class GroupHeadersController : Controller
    {
        private readonly DataContext _context;

        public GroupHeadersController(DataContext context)
        {
            _context = context;
        }

        // GET: GroupHeaders
        public async Task<IActionResult> Index()
        {
            return View(await _context.groupHeaders.ToListAsync());
        }

        // GET: GroupHeaders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupHeader = await _context.groupHeaders
                .SingleOrDefaultAsync(m => m.grpHId == id);
            if (groupHeader == null)
            {
                return NotFound();
            }

            return View(groupHeader);
        }

        // GET: GroupHeaders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GroupHeaders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("grpHId,msgId,nbOfTxs,creDtTm,ttlIntrBKSttlmAmt,intrBkSttlmDt,sttlImInfSttlmMtd,sttlInfPrtry,GRPRTR,GRPTYPE,GRPHRTRID,GRPHSTSID")] GroupHeader groupHeader)
        {
            if (ModelState.IsValid)
            {
                _context.Add(groupHeader);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(groupHeader);
        }

        // GET: GroupHeaders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupHeader = await _context.groupHeaders.SingleOrDefaultAsync(m => m.grpHId == id);
            if (groupHeader == null)
            {
                return NotFound();
            }
            return View(groupHeader);
        }

        // POST: GroupHeaders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("grpHId,msgId,nbOfTxs,creDtTm,ttlIntrBKSttlmAmt,intrBkSttlmDt,sttlImInfSttlmMtd,sttlInfPrtry,GRPRTR,GRPTYPE,GRPHRTRID,GRPHSTSID")] GroupHeader groupHeader)
        {
            if (id != groupHeader.grpHId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(groupHeader);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GroupHeaderExists(groupHeader.grpHId))
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
            return View(groupHeader);
        }

        // GET: GroupHeaders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupHeader = await _context.groupHeaders
                .SingleOrDefaultAsync(m => m.grpHId == id);
            if (groupHeader == null)
            {
                return NotFound();
            }

            return View(groupHeader);
        }

        // POST: GroupHeaders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var groupHeader = await _context.groupHeaders.SingleOrDefaultAsync(m => m.grpHId == id);
            _context.groupHeaders.Remove(groupHeader);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroupHeaderExists(int id)
        {
            return _context.groupHeaders.Any(e => e.grpHId == id);
        }
    }
}
