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
            if (this._player1ScoreTimes == this._player2ScoreTimes)
            {
                if (this._player1ScoreTimes >= 3)
                {
                    return "Deuce";
                }

                var score = scoresLookup[this._player1ScoreTimes];
                return $"{score} All";
            }

            if (IsPlayer2Adv() || IsPlayer1Adv())
            {
                var playerName = IsPlayer2Adv() ? _secondPlayerName : _firstPlayerName;
                return $"{playerName} Adv";
            }

            if (_player1ScoreTimes == 4)
            {
                return this._firstPlayerName + " Win";
            }

            if (_player2ScoreTimes == 4)
            {
                return this._secondPlayerName + " Win";
            }

            var player1Score = GetPlayer1Score();
            var player2Score = GetPlayer2Score();

            return player1Score + " " + player2Score;
        }

        private bool IsPlayer1Adv()
        {
            return _player1ScoreTimes > 3 && _player1ScoreTimes - _player2ScoreTimes == 1;
        }

        private bool IsPlayer2Adv()
        {
            return _player2ScoreTimes > 3 && _player2ScoreTimes - _player1ScoreTimes == 1;
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