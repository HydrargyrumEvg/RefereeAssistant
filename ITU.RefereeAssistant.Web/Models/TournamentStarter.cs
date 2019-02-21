using ITU.RefereeAssistant.Domain;
using ITU.RefereeAssistant.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITU.RefereeAssistant.Web.Models
{
    public class TournamentStarter
    {
        [Display(Name = "Система проведения турнира")]
        public ITournamentType TournamentType{get; set;}
        [Display(Name = "Участники")]
        public  IEnumerable<Player> Player { get; set; }
    }
}