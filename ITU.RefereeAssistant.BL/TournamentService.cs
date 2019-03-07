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
        public Tournament Create(Player[] player, ITournamentType type)
        {
            tourType = type;
            return new Tournament(player);
        }
        /// <summary>
        /// Сформировать раунд
        /// </summary>
        /// <param name="tournament"></param>
        /// <returns></returns>
        public Round GenerateRound(Tournament tournament)
        {            
            var players = tournament.Start;

            var round = tourType.GetNextRound(players, tournament.Rounds);

            tournament.Rounds.Add(round);

            return round;           
        }
    }
}
