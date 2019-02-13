using System;
using System.Collections.Generic;
using System.Text;

namespace ITU.RefereeAssistant.Domain.Models
{
    /// <summary>
    /// Тип системы проведения турнира
    /// </summary>
    public enum TournamentType
    {
        Olimpic, //Олимпийская система
        Swiss,
        Circle,
        Knockout
    }
}
