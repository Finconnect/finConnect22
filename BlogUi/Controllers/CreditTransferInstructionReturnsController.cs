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
    public class CreditTransferInstructionReturnsController : Controller
    {
        private readonly DataContext _context;

        public CreditTransferInstructionReturnsController(DataContext context)
        {
            _context = context;
        }

        // GET: CreditTransferInstructionReturns
        public async Task<IActionResult> Index()
        {
            return View(await _context.creditTransferInstructionReturns.ToListAsync());
        }

        // GET: CreditTransferInstructionReturns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var creditTransferInstructionReturn = await _context.creditTransferInstructionReturns
                .SingleOrDefaultAsync(m => m.cdrtxId == id);
            if (creditTransferInstructionReturn == null)
            {
                return NotFound();
            }

            return View(creditTransferInstructionReturn);
        }

        // GET: CreditTransferInstructionReturns/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CreditTransferInstructionReturns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("cdrtxId,rtrId,orgMsgId,orgMsgNmId,orgDtTm,orgEndToEndId,orgTxId,orgClrSysRef,rtrdIntrBKSttlAmt,rtrRsnInfPrtry,orgTxRefIntrBKSttlmAmt,orgTxRefIntrBKSttlmDt,ogrSvcLvlPrtry,msgDir")] CreditTransferInstructionReturn creditTransferInstructionReturn)
        {
            if (ModelState.IsValid)
            {
                _context.Add(creditTransferInstructionReturn);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(creditTransferInstructionReturn);
        }

        // GET: CreditTransferInstructionReturns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var creditTransferInstructionReturn = await _context.creditTransferInstructionReturns.SingleOrDefaultAsync(m => m.cdrtxId == id);
            if (creditTransferInstructionReturn == null)
            {
                return NotFound();
            }
            return View(creditTransferInstructionReturn);
        }

        // POST: CreditTransferInstructionReturns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("cdrtxId,rtrId,orgMsgId,orgMsgNmId,orgDtTm,orgEndToEndId,orgTxId,orgClrSysRef,rtrdIntrBKSttlAmt,rtrRsnInfPrtry,orgTxRefIntrBKSttlmAmt,orgTxRefIntrBKSttlmDt,ogrSvcLvlPrtry,msgDir")] CreditTransferInstructionReturn creditTransferInstructionReturn)
        {
            if (id != creditTransferInstructionReturn.cdrtxId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(creditTransferInstructionReturn);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CreditTransferInstructionReturnExists(creditTransferInstructionReturn.cdrtxId))
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
            return View(creditTransferInstructionReturn);
        }

        // GET: CreditTransferInstructionReturns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var creditTransferInstructionReturn = await _context.creditTransferInstructionReturns
                .SingleOrDefaultAsync(m => m.cdrtxId == id);
            if (creditTransferInstructionReturn == null)
            {
                return NotFound();
            }

            return View(creditTransferInstructionReturn);
        }

        // POST: CreditTransferInstructionReturns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var creditTransferInstructionReturn = await _context.creditTransferInstructionReturns.SingleOrDefaultAsync(m => m.cdrtxId == id);
            _context.creditTransferInstructionReturns.Remove(creditTransferInstructionReturn);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CreditTransferInstructionReturnExists(int id)
        {
            return _context.creditTransferInstructionReturns.Any(e => e.cdrtxId == id);
        }
    }
}
