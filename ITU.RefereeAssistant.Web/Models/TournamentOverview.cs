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
    public class TournamentOverview
    {
        [Display(Name = "Доступные турниры")]
        public IEnumerable<Tournament> Tournaments { get; set; }                
    }
}