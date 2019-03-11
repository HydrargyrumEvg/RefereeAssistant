using ITU.RefereeAssistant.BL;
using ITU.RefereeAssistant.Domain.Models;
using ITU.RefereeAssistant.Web.Filters;
using ITU.RefereeAssistant.Web.Models;
using ITU.RefereeAssistant.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITU.RefereeAssistant.Web.Controllers
{
    [Authorize]
    public class RoundController : Controller
    {
        private BaseService<Round> RoundService = new BaseService<Round>();
        private BaseService<Match> MatchService = new BaseService<Match>();
        // GET: Round
        [HttpGet]        
        public ActionResult Details(long Id)
        {            
            var round = RoundService.Get(Id);
            if (round.Tournament.Author != User.Identity.Name)
            {
                throw new UnauthorizedAccessException("Нет доступа");
            }            
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
        [HttpGet]
        public ActionResult GenerateNextRound(long Id)
        {
            ViewBag.Message = "";
            Round round = new BaseService<Round>().Get(Id);
            if (round.Tournament.Author != User.Identity.Name)
            {
                throw new UnauthorizedAccessException("Нет доступа");
            }            
            foreach (var match in round.Matches)
            {
                if (match.MatchResult == MatchResult.Draw)
                {
                    ViewBag.Message = "Не для всех матчей указан результат";                    
                    return View("Details", round);
                }
            }            
            Tournament tour = round.Tournament;
            var tourTypes = Helper.LoadTournamentTypes(AppDomain.CurrentDomain.BaseDirectory + @"bin\");
            var tourType = tourTypes.FirstOrDefault(
                item => item.GetType().FullName == tour.Type.TypeName);
            tourType.rounds = tour.Rounds;
            if (tourType.RoundLimit() == tour.Rounds.Count)
            {
                ViewBag.Message = "Матч завершен!";
                return View("Details", round);
            }
            var ts = new BL.TournamentService();
            ts.TourType = tourType;            
            var roundNext = ts.GenerateRound(tour);
            Services.TournamentService TournamentService = new Services.TournamentService();
            TournamentService.Save(tour);                                    
            return RedirectToAction("Details", roundNext);          
        }
    }
}