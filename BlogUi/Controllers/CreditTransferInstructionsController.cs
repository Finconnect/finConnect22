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
    public class CreditTransferInstructionsController : Controller
    {
        private readonly DataContext _context;

        public CreditTransferInstructionsController(DataContext context)
        {
            _context = context;
        }

        // GET: CreditTransferInstructions
        public async Task<IActionResult> Index()
        {
            return View(await _context.creditTransferInstructions.ToListAsync());
        }

        // GET: CreditTransferInstructions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var creditTransferInstruction = await _context.creditTransferInstructions
                .SingleOrDefaultAsync(m => m.cdTxId == id);
            if (creditTransferInstruction == null)
            {
                return NotFound();
            }

            return View(creditTransferInstruction);
        }

        // GET: CreditTransferInstructions/Create
        public IActionResult Create()
        {
            //todo:here
            //List<GroupHeader> grp = new List<GroupHeader>();
            //grp = (from GpHeader in _context.groupHeaders
            //       select GpHeader).ToList();
            //grp.Insert(0, new GroupHeader { grpHId = 0, msgId = "--select msg---" });
            //ViewBag.GRPHeader = grp;

            List<Currency> cur = new List<Currency>();
            cur = (from Currency in _context.currencies
                   select Currency).ToList();
            ViewBag.CURREN = new SelectList(cur, "ccyId", "ccyCd");


            return View();
        }

        // POST: CreditTransferInstructions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreditTransferInstruction creditTransferInstruction)
        {
            if (ModelState.IsValid)
            {
                CreditTransferInstruction model = new CreditTransferInstruction();

                //model.GRPHID = creditTransferInstruction.GRPHID.grpHId;
                
                _context.Add(creditTransferInstruction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(creditTransferInstruction);
        }

        // GET: CreditTransferInstructions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var creditTransferInstruction = await _context.creditTransferInstructions.SingleOrDefaultAsync(m => m.cdTxId == id);
            if (creditTransferInstruction == null)
            {
                return NotFound();
            }
            return View(creditTransferInstruction);
        }

        // POST: CreditTransferInstructions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("pmtIdEndToEndId,pmtIdTxId,intrBkSttlmAm,chrgBr,instInf,cdTxId,msgDir")] CreditTransferInstruction creditTransferInstruction)
        {
            if (id != creditTransferInstruction.cdTxId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(creditTransferInstruction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CreditTransferInstructionExists(creditTransferInstruction.cdTxId))
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
            return View(creditTransferInstruction);
        }

        // GET: CreditTransferInstructions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var creditTransferInstruction = await _context.creditTransferInstructions
                .SingleOrDefaultAsync(m => m.cdTxId == id);
            if (creditTransferInstruction == null)
            {
                return NotFound();
            }

            return View(creditTransferInstruction);
        }

        // POST: CreditTransferInstructions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var creditTransferInstruction = await _context.creditTransferInstructions.SingleOrDefaultAsync(m => m.cdTxId == id);
            _context.creditTransferInstructions.Remove(creditTransferInstruction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CreditTransferInstructionExists(int id)
        {
            return _context.creditTransferInstructions.Any(e => e.cdTxId == id);
        }
    }
}
