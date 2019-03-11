using ITU.RefereeAssistant.BL;
using ITU.RefereeAssistant.Domain.Models;
using ITU.RefereeAssistant.Domain.TourType;
using ITU.RefereeAssistant.Web.Extensions;
using ITU.RefereeAssistant.Web.Models;
using ITU.RefereeAssistant.Web.Services;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITU.RefereeAssistant.Web.Controllers
{
    [Authorize]
    public class TournamentController : Controller
    {
        private PlayerService PlayerService = new PlayerService();
        private Services.TournamentService TournamentService = new Services.TournamentService();
        private BaseService<Round> RoundService = new BaseService<Round>();
        private BaseService<Domain.TournamentType> TournamentTypeService = new BaseService<Domain.TournamentType>();
        [HttpGet]
        public ActionResult Start()
        {
            var model = new TournamentStarter();           
            model.Players = PlayerService.GetAll();
            var types = TournamentTypeService.GetAll();
            var selectList = new SelectList(types, "Id", "Name");
            model.tournamentTypes = selectList;
            return View(model);
        }
        [HttpPost]
        public ActionResult Start(TournamentStarter starter)
        {
            if (ModelState.IsValid)
            {
                if (starter.Players.Any())
                {
                    foreach (var player in starter.Players)
                    {
                        PlayerService.Save(player);
                    }
                }

                var dbTourType = TournamentTypeService.Get(starter.TournamentType.Id);
                var tourTypes = Helper.LoadTournamentTypes(AppDomain.CurrentDomain.BaseDirectory + @"bin\");
                var tourType = tourTypes.FirstOrDefault(
                    item => item.GetType().FullName == dbTourType.TypeName);
                tourType.players = starter.Players;
                var ts = new BL.TournamentService();
                ts.TourType = tourType;
                var tour = ts.Create(starter.Players.ToArray(), dbTourType, User.Identity.Name, starter.Description);
                var round = ts.GenerateRound(tour);
                TournamentService.Save(tour);
                return RedirectToAction("Details", "Round", new { Id = round.Id });
            }
            return View(starter);
        }
        public ActionResult Delete(Player player)
        {
            PlayerService.Delete(player);
            return RedirectToAction("Start");
        }
        public ActionResult Add(Player player)
        {
            PlayerService.Save(player);
            return RedirectToAction("Start");
        }
        [HttpGet]        
        public ActionResult Overview()
        {
            var model = new TournamentOverview();
            model.Tournaments = TournamentService.GetAll();            
            return View(model);
        }
        [HttpGet]
        public ActionResult ShowLastRound(long Id)
        {
            Tournament tour = TournamentService.Get(Id);
            int maxOrderNum = tour.Rounds.Max(r => r.OrderNum);
            long lastRoundId = tour.Rounds.SingleOrDefault(r => r.OrderNum == maxOrderNum).Id;            
            return RedirectToAction("Details", "Round", new { Id=lastRoundId});
        }        
    }
}