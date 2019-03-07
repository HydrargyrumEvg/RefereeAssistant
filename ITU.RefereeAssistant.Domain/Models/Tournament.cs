using System;
using System.Collections.Generic;
using System.Text;

namespace ITU.RefereeAssistant.Domain.Models
{
    public class Tournament
    {
        /// <summary>
        /// ctor
        /// </summary>
        public Tournament()
        {
            Start = new List<Player>();
            Current = new List<Player>();
            Rounds = new List<Round>();
        }
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="start">Стартовый набор команд</param>        
        public Tournament(Player[] start):this()
        {
            foreach (var item in start)
            {
                Start.Add(item);
            }      
            
        }
        #region Скрытые свойства        
        string Name { get; set; }
        public virtual TournamentType Type { get; set; }
        public virtual IList <Player> Start { get; set; }
        public virtual IList <Player> Current { get; set; }
        public virtual IList<Round> Rounds { get; set; }
        #endregion
        public Round GetNextRound()
        {
            throw new NotImplementedException();
        }
    }
}
