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
    public class AgentsController : Controller
    {
        private readonly DataContext _context;

        public AgentsController(DataContext context)
        {
            _context = context;
        }

        // GET: Agents
        public async Task<IActionResult> Index()
        {
            return View(await _context.Agent.ToListAsync());
        }

        // GET: Agents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agent = await _context.Agent
                .SingleOrDefaultAsync(m => m.agtCd == id);
            if (agent == null)
            {
                return NotFound();
            }

            return View(agent);
        }

        // GET: Agents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Agents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("agtCd,agtTypeFlag,agtClrSystemID,agtClrsSystemPrtry,agtBIC,agtBrnchId,agtName,agtStreet,agtBldgNb,agtPostCode,agtTownName,agtCtryDiv,agtCtryName,agtPrtryID,agtPrtryIssuer,agtBranchFlag,agtBranchname,agtAccount,agtIBAN,agtAdrTp,agtDept,agtSubDept,agtCtrySubDvsn,agtAdrLine,agtOthr")] Agent agent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(agent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(agent);
        }

        // GET: Agents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agent = await _context.Agent.SingleOrDefaultAsync(m => m.agtCd == id);
            if (agent == null)
            {
                return NotFound();
            }
            return View(agent);
        }

        // POST: Agents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("agtCd,agtTypeFlag,agtClrSystemID,agtClrsSystemPrtry,agtBIC,agtBrnchId,agtName,agtStreet,agtBldgNb,agtPostCode,agtTownName,agtCtryDiv,agtCtryName,agtPrtryID,agtPrtryIssuer,agtBranchFlag,agtBranchname,agtAccount,agtIBAN,agtAdrTp,agtDept,agtSubDept,agtCtrySubDvsn,agtAdrLine,agtOthr")] Agent agent)
        {
            if (id != agent.agtCd)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(agent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AgentExists(agent.agtCd))
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
            return View(agent);
        }

        // GET: Agents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agent = await _context.Agent
                .SingleOrDefaultAsync(m => m.agtCd == id);
            if (agent == null)
            {
                return NotFound();
            }

            return View(agent);
        }

        // POST: Agents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var agent = await _context.Agent.SingleOrDefaultAsync(m => m.agtCd == id);
            _context.Agent.Remove(agent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AgentExists(int id)
        {
            return _context.Agent.Any(e => e.agtCd == id);
        }
    }
}
