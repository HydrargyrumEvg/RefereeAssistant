﻿using ITU.RefereeAssistant.BL;
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
            if (starter.Players.Any())
            {
                foreach (var player in starter.Players)
                {
                    PlayerService.Save(player);
                }
            }

            var dbTourType = TournamentTypeService.Get(starter.TournamentType.Id);
            //var tourTypes = Helper.LoadTournamentTypes(@"C:\Users\Professional\YandexDisk\Обучение\C#\RefereeAssistant\ITU.RefereeAssistant.Web\bin");
            var tourTypes = Helper.LoadTournamentTypes(AppDomain.CurrentDomain.BaseDirectory + @"bin\");
            var tourType = tourTypes.FirstOrDefault(
                item => item.GetType().FullName == dbTourType.TypeName);
            var ts = new BL.TournamentService();
            var tour = ts.Create(starter.Players.ToArray(), dbTourType, User.Identity.Name, starter.Description);
            ts.TourType = tourType; 
            var round = ts.GenerateRound(tour);
            RoundService.Save(round);
            TournamentService.Save(tour);
            return RedirectToAction("Details", "Round", new { Id = round.Id});
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
        [Authorize]
        public ActionResult Overview()
        {
            var model = new TournamentOverview();
            model.Tournaments = TournamentService.GetAll();
            //model.Players = PlayerService.GetAll();
            //var types = TournamentTypeService.GetAll();
            //var selectList = new SelectList(types, "Id", "Name");
            //model.tournamentTypes = selectList;
            return View(model);
        }
        [HttpPost]
        public void RoundLast(Tournament entity)
        {
            var t = "test";
        }
        // GET: Tourament
    }
}