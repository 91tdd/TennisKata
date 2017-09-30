using System.Collections.Generic;

namespace TennisKata
{
    public class TennisGame
    {
        private readonly string _firstPlayerName;
        private readonly string _secondPlayerName;
        private int _player1ScoreTimes;
        private int _player2ScoreTimes;

        private Dictionary<int, string> scoresLookup = new Dictionary<int, string>()
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"},
        };

        public TennisGame(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

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
            if (this._player1ScoreTimes == 1 && this._player2ScoreTimes == 1)
            {
                return "Fifteen" + " All";
            }
            else if (this._player1ScoreTimes == 2 && this._player2ScoreTimes == 2)
            {
                return "Thirty" + " All";
            }
            else if (this._player1ScoreTimes == 0 && this._player2ScoreTimes == 0)
            {
                return "Love" + " All";
            }

            if (_player1ScoreTimes == 4)
            {
                return this._firstPlayerName + " Win";
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