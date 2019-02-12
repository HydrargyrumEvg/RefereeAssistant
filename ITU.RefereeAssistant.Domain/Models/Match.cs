using System;
using System.Collections.Generic;
using System.Text;

namespace ITU.RefereeAssistant.Domain.Models
{
    class Match
    {
        long Id { get; set; }
        Player[] players { get; set; }
        Player[] Ratings { get; set; }
    }
}
