using System;
using System.Collections.Generic;
using System.Text;

namespace ITU.RefereeAssistant.Domain.Models
{
    public class Round
    {
        public Round()
        {
            Matches = new List<Match>();
        }
        long Id { get; set; }
        public List<Match> Matches { get; set; }

        public void AddMatch(Match match)
        {
            Matches.Add(match);
        }
    }
}
