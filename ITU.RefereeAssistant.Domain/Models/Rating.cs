using System;
using System.Collections.Generic;
using System.Text;

namespace ITU.RefereeAssistant.Domain.Models
{
    class Rating
    {
        Player Player { get; set; }
        long Score { get; set; }
    }
}
