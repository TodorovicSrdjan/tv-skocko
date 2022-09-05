using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSkocko_872019
{
    public class PlayerScore
    {
        public PlayerScore()
        {
        }

        public PlayerScore(string playerName, int numberOfGuesses, int gameDuration, bool hasGuessedSolution)
        {
            PlayerName = playerName;
            NumberOfGuesses = numberOfGuesses;
            GameDuration = gameDuration;
            HasGuessedSolution = hasGuessedSolution;
        }

        public String PlayerName { get; set; }
        public int NumberOfGuesses { get; set; }
        public int GameDuration { get; set; }
        public bool HasGuessedSolution { get; set; }
        public int Score { get; set; }
    }
}
