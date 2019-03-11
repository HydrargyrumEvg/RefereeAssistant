using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ITU.RefereeAssistant.BL;

namespace ITU.RefereeAssistant.Domain.Models
{
    public class Round : IEntity
    {
        public Round()
        {
            Matches = new List<Match>();
        }

        public virtual long Id { get; set; }
        public virtual int OrderNum { get; set; }
        public virtual Tournament Tournament { get; set; }

        public virtual ICollection<Match> Matches { get; set; }

        public virtual void AddMatch(Match match)
        {
            match.Round = this;
            Matches.Add(match);
        }
    }
}
