using ITU.RefereeAssistant.Domain;
using ITU.RefereeAssistant.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITU.RefereeAssistant.BL
{
    /// <summary>
    /// Сервис для работы с турнирами
    /// </summary>
    public class TournamentService
    {
        ITournamentType tourType { get; set; }
        /// <summary>
        /// Создать новый турнир <see cref="Tournament"/>
        /// </summary>
        /// <returns>Турнир</returns>
        public Tournament Create(Rating[] ratings, ITournamentType type)
        {
            tourType = type;
            return new Tournament(ratings);
        }
        /// <summary>
        /// Сформировать раунд
        /// </summary>
        /// <param name="tournament"></param>
        /// <returns></returns>
        public Round GenerateRound(Tournament tournament)
        {
            var players = tournament.Start.Select(rating => rating.Player);
            var round = tourType.GetNextRound(players, tournament.Rounds);
            tournament.Rounds.Add(round);
            return round;
        }
    }
}
