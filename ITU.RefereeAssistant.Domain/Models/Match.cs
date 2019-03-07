using System;
using System.Collections.Generic;

namespace ITU.RefereeAssistant.Domain.Models
{
    /// <summary>
    /// Матч
    /// </summary>
    public class Match : IEntity
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public Match()
        {
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public virtual long Id { get; set; }

        /// <summary>
        /// Участники
        /// </summary>
        [Obsolete("Используйте свойства FirstPlayer и SecondPlayer", true)]
        public virtual IList<Player> Players
        {
            get { return new List<Player>() { FirstPlayer, SecondPlayer }; }
            set
            {
                if (value.Count >= 2)
                {
                    FirstPlayer = value[0];
                    SecondPlayer = value[1];
                }
            }
        }

        public virtual Player FirstPlayer { get; set; }

        public virtual Player SecondPlayer { get; set; }

        /// <summary>
        /// Результат матча
        /// </summary>
        public virtual MatchResult MatchResult { get; set; }

        public virtual Round Round { get; set; }

    }
}