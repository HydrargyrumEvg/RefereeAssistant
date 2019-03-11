using ITU.RefereeAssistant.Domain;
using ITU.RefereeAssistant.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITU.RefereeAssistant.Web.Models
{
    public class TournamentStarter
    {
        [Display(Name = "Система проведения турнира")]
        public TournamentType TournamentType{get; set;}
        [Display(Name = "Название турнира")]
        [Required(ErrorMessage = "Должно быть указано название турнира")]
        public string Description { get; set; }
        [Display(Name = "Участники")]
        public  IEnumerable<Player> Players { get; set; }
        public SelectList tournamentTypes { get; set; }
    }
}