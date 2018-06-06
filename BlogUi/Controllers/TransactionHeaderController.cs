using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogUi.Ef;
using BlogUi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogUi.Controllers
{
    public class TransactionHeaderController : Controller
    {
        private readonly DataContext _context;

        public TransactionHeaderController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<CreditTransferInstruction> cred = new List<CreditTransferInstruction>();
            string query = "SELECT * FROM creditTransferInstructions WHERE grpHId is null";
            

            var credits = _context.creditTransferInstructions
                            .Where(s => s.GRPHID == null).ToList();

            
            return View(credits);
        }
    }
}