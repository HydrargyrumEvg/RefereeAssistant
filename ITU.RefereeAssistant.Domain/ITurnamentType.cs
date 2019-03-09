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
        /// <summary>
        /// Получить следующий раунд
        /// </summary>
        /// <returns></returns>
        Round GetNextRound(IEnumerable<Player> players, IEnumerable<Round> rounds);
    }
}
