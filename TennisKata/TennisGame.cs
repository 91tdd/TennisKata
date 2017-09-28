using System.Collections.Generic;

namespace TennisKata
{
    public class TennisGame
    {
        private int _player1ScoreTimes;
        private int _player2ScoreTimes;

        private Dictionary<int, string> scoresLookup = new Dictionary<int, string>()
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"},
        };

        public void Player1Score()
        {
            this._player1ScoreTimes++;
        }

        public void Player2Score()
        {
            this._player2ScoreTimes++;
        }

        public string ShowScore()
        {
            if (this._player1ScoreTimes == 0 && this._player2ScoreTimes == 0)
            {
                return "Love All";
            }

            var player1Score = GetPlayer1Score();
            var player2Score = GetPlayer2Score();

            return player1Score + " " + player2Score;
        }

        private string GetPlayer2Score()
        {
            return scoresLookup[this._player2ScoreTimes];
        }

        private string GetPlayer1Score()

        {
            return scoresLookup[this._player1ScoreTimes];
        }
    }
}