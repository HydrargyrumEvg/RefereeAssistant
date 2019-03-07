using ITU.RefereeAssistant.Domain.Models;
using ITU.RefereeAssistant.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITU.RefereeAssistant.Web.Controllers
{
    public class RoundController : Controller
    {
        private BaseService<Round> RoundService = new BaseService<Round>();
        private BaseService<Match> MatchService = new BaseService<Match>();
        // GET: Round
        public ActionResult Details(long Id)
        {
            var round = RoundService.Get(Id);
            return View(round);
        }
        [HttpPost]
        public string SaveMatchResult(long Id, MatchResult matchResult)
        {
            var match = MatchService.Get(Id);
            match.MatchResult = matchResult;
            MatchService.Save(match);
            return "сохранено";
        }
    }
}