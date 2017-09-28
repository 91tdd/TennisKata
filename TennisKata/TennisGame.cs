using System.Collections.Generic;

namespace TennisKata
{
    public class TennisGame
    {
        private int _player1ScoreTimes;
        private int _player2ScoreTimes;

        private Dictionary<int, string> scoresLookup = new Dictionary<int, string>()
        {
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
            var score = "";
            if (this._player1ScoreTimes == 0 && this._player2ScoreTimes == 0)
            {
                score = "Love All";
            }

            if (this._player2ScoreTimes > 0)
            {
                score = "Love Fifteen";
            }

            if (this._player1ScoreTimes > 0)
            {
                var player1Score = GetPlayer1Score();

                score = player1Score + " Love";
            }

            return score;
        }

        private string GetPlayer1Score()

        {
            ;

            return scoresLookup[this._player1ScoreTimes];
        }
    }
}