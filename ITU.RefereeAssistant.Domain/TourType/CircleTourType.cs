﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ITU.RefereeAssistant.Domain.Models;

namespace ITU.RefereeAssistant.Domain.TourType
{
    public class CircleTourType : ITournamentType
    {
        public string Name => "Круговая система";
        
        public Round GetNextRound(IEnumerable<Player> players, IEnumerable<Round> rounds)
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
                var match = new Match();
                var player1 = currentPlayers.ElementAt(i * 2);
                var player2 = currentPlayers.ElementAt(i * 2 + 1);

                match.FirstPlayer = player1;
                match.SecondPlayer = player2;                

                round.AddMatch(match);
            }            
            return round;
        }
    }
}
