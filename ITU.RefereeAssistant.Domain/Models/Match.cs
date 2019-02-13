using System;
using System.Collections.Generic;
using System.Text;

namespace ITU.RefereeAssistant.Domain.Models
{
    public class Match
    {
        public Match()
        {
            Players = new List<Player>();
        }
        long Id { get; set; }
        public List<Player> Players { get; set; }
        Player[] Ratings { get; set; }
        public override string ToString()
        {
            return String.Join(" | ", Players);
        }
    }
}
