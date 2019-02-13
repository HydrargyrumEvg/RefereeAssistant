using System;
using System.Collections.Generic;
using System.Text;

namespace ITU.RefereeAssistant.Domain.Models
{
    public class Rating
    {
        public Player Player { get; set; }
        long Score { get; set; }
    }
}
