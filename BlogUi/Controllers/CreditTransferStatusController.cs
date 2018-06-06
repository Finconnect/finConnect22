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
    public class CreditTransferStatusController : Controller
    {
        private readonly DataContext _context;

        public CreditTransferStatusController(DataContext context)
        {
            _context = context;
        }

        // GET: CreditTransferStatus
        public async Task<IActionResult> Index()
        {
            return View(await _context.creditTransferStatuses.ToListAsync());
        }

        // GET: CreditTransferStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var creditTransferStatus = await _context.creditTransferStatuses
                .SingleOrDefaultAsync(m => m.txStsId == id);
            if (creditTransferStatus == null)
            {
                return NotFound();
            }

            return View(creditTransferStatus);
        }

        // GET: CreditTransferStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CreditTransferStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("txStsId,stsId,orgEndToEndId,orgTxId,stsRsnPrtry,clrSysRef,orgTxRefIntrBKSttlmAmt,orgTxRefIntrBkSttlDt,orgTxRefDbtrAgtBIC,orgTxRefCdtrAgtBIC")] CreditTransferStatus creditTransferStatus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(creditTransferStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(creditTransferStatus);
        }

        // GET: CreditTransferStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var creditTransferStatus = await _context.creditTransferStatuses.SingleOrDefaultAsync(m => m.txStsId == id);
            if (creditTransferStatus == null)
            {
                return NotFound();
            }
            return View(creditTransferStatus);
        }

        // POST: CreditTransferStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("txStsId,stsId,orgEndToEndId,orgTxId,stsRsnPrtry,clrSysRef,orgTxRefIntrBKSttlmAmt,orgTxRefIntrBkSttlDt,orgTxRefDbtrAgtBIC,orgTxRefCdtrAgtBIC")] CreditTransferStatus creditTransferStatus)
        {
            if (id != creditTransferStatus.txStsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(creditTransferStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CreditTransferStatusExists(creditTransferStatus.txStsId))
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
            return View(creditTransferStatus);
        }

        // GET: CreditTransferStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var creditTransferStatus = await _context.creditTransferStatuses
                .SingleOrDefaultAsync(m => m.txStsId == id);
            if (creditTransferStatus == null)
            {
                return NotFound();
            }

            return View(creditTransferStatus);
        }

        // POST: CreditTransferStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var creditTransferStatus = await _context.creditTransferStatuses.SingleOrDefaultAsync(m => m.txStsId == id);
            _context.creditTransferStatuses.Remove(creditTransferStatus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CreditTransferStatusExists(int id)
        {
            return _context.creditTransferStatuses.Any(e => e.txStsId == id);
        }
    }
}
