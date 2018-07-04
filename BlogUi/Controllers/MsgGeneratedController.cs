using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogUi.Ef;
using Microsoft.AspNetCore.Mvc;
using BlogUi.Models;
using EntityManager;
namespace BlogUi.Controllers
{
    public class MsgGeneratedController : Controller
    {
        private readonly DataContext _context;

        public MsgGeneratedController(DataContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            
            GroupHeader grp = new GroupHeader();
            var credits = _context.groupHeaders
                            .Where(m => m.grpHId == 1).SingleOrDefault();
            //todo :here to generate msg
            //EntityManager.Xml_grpHeader.FIToFICstmrCdtTrf Message = new Xml_grpHeader.FIToFICstmrCdtTrf();
            //Message.GrpHdr = new Xml_grpHeader.GrpHdr
            //{
            //    
            //    CreDtTm = grp.creDtTm.ToString(),
            //    //InstdAgt = grp.
            //};

            //var test = from s in _context.groupHeaders

            //           join sa in _context.creditTransferInstructions on s.grpHId equals sa.GRPHID.grpHId
            //           where s.grpHId == 1
            //           select s;

            grp = new GroupHeader
            {
                grpHId = credits.grpHId,
                msgId = credits.msgId,
                //nbOfTxs = credits.nbOfTxs,
                creDtTm = credits.creDtTm,
                ttlIntrBKSttlmAmt = credits.ttlIntrBKSttlmAmt,
                intrBkSttlmDt = credits.intrBkSttlmDt,
                sttlImInfSttlmMtd = credits.sttlImInfSttlmMtd,
                sttlInfPrtry = credits.sttlInfPrtry,
                _ORGMSGSTATUSID = credits._ORGMSGSTATUSID,
                GRPRTR = credits.GRPRTR,
                GRPTYPE = credits.GRPTYPE,
                GRPHRTRID = credits.GRPHRTRID,
                GRPHSTSID = credits.GRPHSTSID,
                creditTransferInstruction = credits.creditTransferInstruction

            };

            List<CreditTransferInstruction> Inst = new List<CreditTransferInstruction>();

            Inst = _context.creditTransferInstructions
                                            .Where(s => s.GRPHID.grpHId == 1).ToList();

            grp.nbOfTxs = Inst.Count();

            //var query = from x in _context.groupHeaders.Where(c => c.grpHId == 1)
            //            select new GroupHeader
            //            {
            //                grpHId = x.grpHId,

            //                creditTransferInstruction = (from t in x.creditTransferInstruction.Where(c => c.GRPHID.grpHId == x.grpHId)
            //                                             select new CreditTransferInstruction
            //                                             {
            //                                                 cdTxId = t.cdTxId,
            //                                                 agents = (
            //                                                            from a in t.agents.Where(c => !c.As.Any 
            //                                                           ).ToList()
            //                                             }).ToList()


            //            };

            //var msg = from g in _context.groupHeaders
            //          where g.grpHId == 1
            //          select new
            //          {
            //              g.grpHId,
            //              g.creditTransferInstruction

            //        };
            //
            List<Agent> lstAgt = new List<Agent>();
            //foreach (var i in Inst)
            //{
            //    Agent agt = new Agent();
            //    //agt = _context.Agent.Where(s => s.agtCd == ).ToList();
            //    var Agents = from a in _context.Agent
            //                 join b in _context.creditTransferInstructions
            //                 on a.agtCd equals b.agents 
            //                 where b.creditTransferInstruction.cdTxId == i.cdTxId
            //                 select new
            //                 {
            //                     a.agtClrSystemID,
            //                     a.agtClrsSystemPrtry,
            //                     a.agtBIC,
            //                     a.agtBrnchId,
            //                     a.agtName,
            //                     a.agtStreet,
            //                     a.agtBldgNb,
            //                     a.agtPostCode,
            //                     a.agtTownName,
            //                     a.agtCtryDiv,
            //                     a.agtCtryName,
            //                     a.agtPrtryID,
            //                     a.agtPrtryIssuer,
            //                     a.agtBranchFlag,
            //                     a.agtBranchname,
            //                     a.agtAccount,
            //                     a.agtIBAN,
            //                     a.agtAdrTp,
            //                     a.agtDept,
            //                     a.agtSubDept,
            //                     a.agtCtrySubDvsn,
            //                     a.agtAdrLine,
            //                     a.agtOthr
            //                 };


            //}


            //grp = test.FirstOrDefault();
            return View(grp);

        }
    }
}