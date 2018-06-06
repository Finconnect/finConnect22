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
    public class OrgMsgStatusController : Controller
    {
        private readonly DataContext _context;

        public OrgMsgStatusController(DataContext context)
        {
            _context = context;
        }

        // GET: OrgMsgStatus
        public async Task<IActionResult> Index()
        {
            return View(await _context.orgMsgStatuses.ToListAsync());
        }

        // GET: OrgMsgStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orgMsgStatus = await _context.orgMsgStatuses
                .SingleOrDefaultAsync(m => m.orgMsgStatusId == id);
            if (orgMsgStatus == null)
            {
                return NotFound();
            }

            return View(orgMsgStatus);
        }

        // GET: OrgMsgStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrgMsgStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("orgMsgId,orgMsgNmId,orgNbOfTx,stsRsnInfPrtry,stsRsnAddtlInf,dtldNbOfTxs,dtldSts,dtldCtrlSum,orgMsgStatusId")] OrgMsgStatus orgMsgStatus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orgMsgStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(orgMsgStatus);
        }

        // GET: OrgMsgStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orgMsgStatus = await _context.orgMsgStatuses.SingleOrDefaultAsync(m => m.orgMsgStatusId == id);
            if (orgMsgStatus == null)
            {
                return NotFound();
            }
            return View(orgMsgStatus);
        }

        // POST: OrgMsgStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("orgMsgId,orgMsgNmId,orgNbOfTx,stsRsnInfPrtry,stsRsnAddtlInf,dtldNbOfTxs,dtldSts,dtldCtrlSum,orgMsgStatusId")] OrgMsgStatus orgMsgStatus)
        {
            if (id != orgMsgStatus.orgMsgStatusId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orgMsgStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrgMsgStatusExists(orgMsgStatus.orgMsgStatusId))
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
            return View(orgMsgStatus);
        }

        // GET: OrgMsgStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orgMsgStatus = await _context.orgMsgStatuses
                .SingleOrDefaultAsync(m => m.orgMsgStatusId == id);
            if (orgMsgStatus == null)
            {
                return NotFound();
            }

            return View(orgMsgStatus);
        }

        // POST: OrgMsgStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orgMsgStatus = await _context.orgMsgStatuses.SingleOrDefaultAsync(m => m.orgMsgStatusId == id);
            _context.orgMsgStatuses.Remove(orgMsgStatus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrgMsgStatusExists(int id)
        {
            return _context.orgMsgStatuses.Any(e => e.orgMsgStatusId == id);
        }
    }
}
