using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ITU.RefereeAssistant.Domain.Models;

namespace ITU.RefereeAssistant.Domain.TourType
{
    public class CircleTourType : ITournamentType
    {
        public string Name => "Круговая система";        
        public IEnumerable<Player> players { get; set; }
        public IEnumerable<Round> rounds { get; set; }
        public int RoundLimit()
        {
            int playerCount = players.Count();
            if (players.Count() == 0)
            {
                Round firstRound = rounds.SingleOrDefault(r => r.OrderNum == 1);
                playerCount = firstRound.Matches.Count() * 2;
            }
            return Convert.ToInt32(Math.Log(playerCount, 2));
        }

        public Round GetNextRound()
        {
            var playerCount = players.Count();
            var roundCount = rounds.Count();
            var roundLimit = Math.Log(playerCount, 2);
            if (roundCount >= roundLimit)
            {
                return null;
            }
            var winners = new List<Player>();
            var lastRound = rounds.LastOrDefault();
            if (lastRound != null)
            {
                foreach (var match in lastRound.Matches)
                {
                    if (match.MatchResult == MatchResult.FirstWin)
                    {
                        winners.Add(match.FirstPlayer);
                    }
                    else if (match.MatchResult == MatchResult.SecondWin)
                    {
                        winners.Add(match.SecondPlayer);
                    }
                }
            }
            var currentPlayers = lastRound == null
                ? players
                : winners;

            var round = new Round();
            var matchCount = currentPlayers.Count() / 2;
            for (int i = 0; i < matchCount; i++)
            {
                var match = new Match()
                {
                    FirstPlayer = currentPlayers.ElementAt(i * 2),
                    SecondPlayer = currentPlayers.ElementAt(i * 2 + 1)
                };

                round.AddMatch(match);
            }
            return round;
        }
    }
}
