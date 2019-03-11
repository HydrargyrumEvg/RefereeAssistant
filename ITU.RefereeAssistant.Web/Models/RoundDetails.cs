using ITU.RefereeAssistant.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITU.RefereeAssistant.Web.Models
{
    public class RoundDetails
    {
        [Display(Name = "Раунд")]
        public Round Round { get; set; }                        
    }
}