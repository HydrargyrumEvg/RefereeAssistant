using System;
using System.Collections.Generic;
using System.Text;

namespace ITU.RefereeAssistant.Domain.Models
{
    public class Rating
    {
        public Rating(Player player)
        {
            Player = player;
            Score = 0;
        }
        public Player Player { get; set; }
        public long Score { get; set; }
    }
}
