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
    public class GroupHeaderReturnsController : Controller
    {
        private readonly DataContext _context;

        public GroupHeaderReturnsController(DataContext context)
        {
            _context = context;
        }

        // GET: GroupHeaderReturns
        public async Task<IActionResult> Index()
        {
            return View(await _context.groupHeaderReturns.ToListAsync());
        }

        // GET: GroupHeaderReturns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupHeaderReturn = await _context.groupHeaderReturns
                .SingleOrDefaultAsync(m => m.grpHrtId == id);
            if (groupHeaderReturn == null)
            {
                return NotFound();
            }

            return View(groupHeaderReturn);
        }

        // GET: GroupHeaderReturns/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GroupHeaderReturns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("grpHrtId,msgId,creDtTm,nbOfTxs,grpRtr,ttlRtrdIntrBKSttlmAmt,intrBkSttlmDt,sttlImInfSttlmMtd,sttlInfPrtry")] GroupHeaderReturn groupHeaderReturn)
        {
            if (ModelState.IsValid)
            {
                _context.Add(groupHeaderReturn);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(groupHeaderReturn);
        }

        // GET: GroupHeaderReturns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupHeaderReturn = await _context.groupHeaderReturns.SingleOrDefaultAsync(m => m.grpHrtId == id);
            if (groupHeaderReturn == null)
            {
                return NotFound();
            }
            return View(groupHeaderReturn);
        }

        // POST: GroupHeaderReturns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("grpHrtId,msgId,creDtTm,nbOfTxs,grpRtr,ttlRtrdIntrBKSttlmAmt,intrBkSttlmDt,sttlImInfSttlmMtd,sttlInfPrtry")] GroupHeaderReturn groupHeaderReturn)
        {
            if (id != groupHeaderReturn.grpHrtId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(groupHeaderReturn);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GroupHeaderReturnExists(groupHeaderReturn.grpHrtId))
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
            return View(groupHeaderReturn);
        }

        // GET: GroupHeaderReturns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupHeaderReturn = await _context.groupHeaderReturns
                .SingleOrDefaultAsync(m => m.grpHrtId == id);
            if (groupHeaderReturn == null)
            {
                return NotFound();
            }

            return View(groupHeaderReturn);
        }

        // POST: GroupHeaderReturns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var groupHeaderReturn = await _context.groupHeaderReturns.SingleOrDefaultAsync(m => m.grpHrtId == id);
            _context.groupHeaderReturns.Remove(groupHeaderReturn);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroupHeaderReturnExists(int id)
        {
            return _context.groupHeaderReturns.Any(e => e.grpHrtId == id);
        }
    }
}
