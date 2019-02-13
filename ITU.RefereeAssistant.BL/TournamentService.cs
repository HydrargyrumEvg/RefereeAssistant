using ITU.RefereeAssistant.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITU.RefereeAssistant.BL
{
    /// <summary>
    /// Сервис для работы с турнирами
    /// </summary>
    public class TournamentService
    {
        /// <summary>
        /// Создать новый турнир <see cref="Tournament"/>
        /// </summary>
        /// <returns>Турнир</returns>
        public Tournament Create(Rating[] ratings, TournamentType type)
        {
            var tournament = new Tournament(ratings, type);
            return tournament;
        }
        /// <summary>
        /// Сформировать раунд
        /// </summary>
        /// <param name="tournament"></param>
        /// <returns></returns>
        public Round GenerateRound(Tournament tournament)
        {
            var round = tournament.GetNextRound();
            return round;
        }
    }
}
