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
            Ratings = new List<Rating>();
        }
        long Id { get; set; }
        public IList<Player> Players { get; set; }
        public IList<Rating> Ratings { get; set; }
        public override string ToString()
        {
            return String.Join(" | ", Players);
        }
    }
}
