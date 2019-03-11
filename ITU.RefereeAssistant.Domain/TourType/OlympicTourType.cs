using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ITU.RefereeAssistant.Domain.Models;

namespace ITU.RefereeAssistant.Domain.TourType
{
    public class OlympicTourType : ITournamentType
    {
        public string Name => "Олимпийская система";
        public IEnumerable<Player> players { get; set; }
        public IEnumerable<Round> rounds { get; set; }
        public OlympicTourType()
        {
            players = new List<Player>();
            rounds = new List<Round>();
        }
        public int RoundLimit()
        {
            int playerCount = 0;
            if (players != null)
            {
                playerCount = players.Count();
            }
            if (playerCount == 0)
            { 
                Round firstRound = rounds.SingleOrDefault(r => r.OrderNum == 1);
                playerCount = firstRound.Matches.Count() * 2;
            }
            double d = Math.Log(playerCount, 2);
            int i = Convert.ToInt32(Math.Floor(d));
            return i;
        }

        public Round GetNextRound()
        {                        
            var roundCount = rounds.Count();
            var roundLimit = this.RoundLimit();
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
