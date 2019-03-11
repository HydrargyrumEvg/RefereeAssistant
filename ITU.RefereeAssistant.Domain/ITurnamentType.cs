using ITU.RefereeAssistant.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITU.RefereeAssistant.Domain
{
    /// <summary>
    /// Система проведения турниров
    /// </summary>
    public interface ITournamentType
    {
        /// <summary>
        /// Название
        /// </summary>
        string Name { get; }
        IEnumerable<Player> players { get; set; }
        IEnumerable<Round> rounds { get; set; }
        /// <summary>
        /// Получить следующий раунд
        /// </summary>
        /// <returns></returns>
        Round GetNextRound();
        int RoundLimit();
    }
}
