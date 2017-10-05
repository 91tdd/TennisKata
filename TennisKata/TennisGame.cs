using System;
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
            _player1ScoreTimes++;
        }

        public void Player2Score()
        {
            _player2ScoreTimes++;
        }

        public string ShowScore()
        {
            if (IsSameScore())
            {
                if (_player1ScoreTimes >= 3)
                {
                    return "Deuce";
                }

                return $"{scoresLookup[_player1ScoreTimes]} All";
            }

            if (IsSomeoneReadyForWin())
            {
                var scoreTimesDiff = Math.Abs(_player2ScoreTimes - _player1ScoreTimes);

                return $"{GetCandidiatePlayerName()} {(scoreTimesDiff == 1 ? "Adv" : "Win")}";
            }

            return $"{GetPlayer1Score()} {GetPlayer2Score()}";
        }

        private bool IsSomeoneReadyForWin()
        {
            return _player2ScoreTimes >= 4 || _player1ScoreTimes >= 4;
        }

        private bool IsSameScore()
        {
            return _player1ScoreTimes == _player2ScoreTimes;
        }

        private string GetCandidiatePlayerName()
        {
            return _player2ScoreTimes > _player1ScoreTimes ? _secondPlayerName : _firstPlayerName;
        }

        private string GetPlayer2Score()
        {
            return scoresLookup[_player2ScoreTimes];
        }

        private string GetPlayer1Score()
        {
            return scoresLookup[_player1ScoreTimes];
        }
    }
}