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
            Start = new List<Rating>();
            Current = new List<Rating>();
            Rounds = new List<Round>();
        }
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="start">Стартовый набор команд</param>
        /// <param name="type">Тип системы проведения турнира</param>
        public Tournament(Rating[] start, TournamentType type):this()
        {
            Start.AddRange(start);
            Type = type;
        }
        #region Скрытые свойства        
        string Name { get; set; }
        TournamentType Type { get; set; }
        List <Rating> Start { get; set; }
        List <Rating> Current { get; set; }
        List<Round> Rounds { get; set; }
        #endregion
        public Round GetNextRound()
        {
            var round = new Round();
            var count = Start.Count;

            var matchCount = count / 2;
            for (int i = 0; i < matchCount; i++)
            {
                var match = new Match();
                switch (Type)
                {
                    case TournamentType.Swiss:
                        match.Players.Add(Start[i].Player);
                        match.Players.Add(Start[count - i - 1].Player);
                        break;
                    case TournamentType.Olimpic:
                        match.Players.Add(Start[i * 2].Player);
                        match.Players.Add(Start[i * 2 + 1].Player);
                        break;
                    default:
                        break;
                }                                                              

                round.AddMatch(match);
            }
            Rounds.Add(round);
            return round;
        }
    }
}
