using System;
using System.Collections.Generic;
using System.Text;

namespace ITU.RefereeAssistant.Domain.Models
{
    class Round
    {
        long Id { get; set; }
        Match[] Match { get; set }
    }
}
