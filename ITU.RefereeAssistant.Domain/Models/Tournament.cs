using System;
using System.Collections.Generic;
using System.Text;

namespace ITU.RefereeAssistant.Domain.Models
{
    class Tournament
    {
        string Name { get; set; }
        TournamentType type { get; set; }
        Rating[] start { get; set; }
        Rating[] Current { get; set; }
        Round[] rounds { get; set; }
    }
}
