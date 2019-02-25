using ITU.RefereeAssistant.Domain.Models;
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
        [HttpGet]
        public ActionResult Start()
        {
            var model = new TournamentStarter();           
            model.Player = PlayerService.GetAll();

            return View(model);
        }
        [HttpPost]
        public ActionResult Start(TournamentStarter starter)
        {
            return View();
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
        // GET: Tourament
        public ActionResult Index(User user)
        {            
            return View("Edit", user);
        }
        [HttpPost]
        public ActionResult Save(User user)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", user);
            }
            if (user.Age < 10)
            {
                ModelState.AddModelError("Age", "Что-то не так с возрастом");
                return View("Edit", user);
            }
            user.Age *= 2;
            return View("Edit", user);
        }
    }
}