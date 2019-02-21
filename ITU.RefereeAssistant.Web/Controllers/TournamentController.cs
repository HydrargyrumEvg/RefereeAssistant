using ITU.RefereeAssistant.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITU.RefereeAssistant.Web.Controllers
{
    public class TournamentController : Controller
    {
        [HttpGet]
        public ActionResult Start()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Start(TournamentStarter starter)
        {
            return View();
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