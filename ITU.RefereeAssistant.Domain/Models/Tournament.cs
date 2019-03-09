using System;
using System.Collections.Generic;
using System.Text;

namespace ITU.RefereeAssistant.Domain.Models
{
    public class Tournament : IEntity
    {
        public virtual long Id { get; set; }
        public virtual string Description { get; set; }
        public virtual string Author { get; set; }
        public virtual Domain.TournamentType Type { get; set; }
        public virtual ICollection<Player> Start { get; set; }
        //public virtual IList<Player> Current { get; set; }
        public virtual ICollection<Round> Rounds { get; set; } 
        /// <summary>
        /// ctor
        /// </summary>
        public Tournament()
        {
            Start = new List<Player>();
            //Current = new List<Player>();
            Rounds = new List<Round>();            
        }
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="start">Стартовый набор команд</param>        
        public Tournament(Player[] start, Domain.TournamentType type, string author, string description):this()
        {
            foreach (var item in start)
            {
                Start.Add(item);
            }
            Type = type;
            Author = author;
            Description = description;
        }        
        public virtual Round GetNextRound()
        {
            throw new NotImplementedException();
        }
    }
}
