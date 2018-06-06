using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BlogUi.Ef;
using BlogUi.Models;
using System.Xml.Serialization;
using System.IO;
using EntityManager;
namespace BlogUi.Controllers
{
    public class CreditTransferInstructions11 : Controller
    {
        private readonly DataContext _context;

        public CreditTransferInstructions11(DataContext context)
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
            EntityManager.Helper help = new EntityManager.Helper();
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
            //todo :here to create msg

            //XML_CreditTransferInstruction xml = new XML_CreditTransferInstruction();
            //xml.chrgBr = creditTransferInstruction.chrgBr;
            //xml.instInf = creditTransferInstruction.instInf;
            //xml.intrBkSttlmAm = creditTransferInstruction.intrBkSttlmAm;
            //xml.msgDir = creditTransferInstruction.msgDir;
            //xml.pmtIdEndToEndId = creditTransferInstruction.pmtIdEndToEndId;
            //xml.pmtIdTxId = creditTransferInstruction.pmtIdTxId;
            //XmlSerializer serializer = new XmlSerializer(typeof(XML_CreditTransferInstruction));
            //help.SaveXML(serializer, xml, id);
            return View(creditTransferInstruction);
        }

        // GET: CreditTransferInstructions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CreditTransferInstructions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("pmtIdEndToEndId,pmtIdTxId,intrBkSttlmAm,chrgBr,instInf,cdTxId,msgDir")] CreditTransferInstruction creditTransferInstruction)
        {
            if (ModelState.IsValid)
            {
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
