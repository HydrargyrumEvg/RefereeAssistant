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
        public ITournamentType TourType { get; set; }
        string Description { get; set; }
        string Author { get; set; }
        /// <summary>
        /// Создать новый турнир <see cref="Tournament"/>
        /// </summary>
        /// <returns>Турнир</returns>
        public Tournament Create(Player[] player, Domain.TournamentType type, string author, string description)
        {            
            return new Tournament(player, type, author, description);            
        }
        /// <summary>
        /// Сформировать раунд
        /// </summary>
        /// <param name="tournament"></param>
        /// <returns></returns>
        public Round GenerateRound(Tournament tournament)
        {            
            var players = tournament.Start;            

            var round = TourType.GetNextRound();

            tournament.AddRound(round);

            return round;           
        }
    }
}
