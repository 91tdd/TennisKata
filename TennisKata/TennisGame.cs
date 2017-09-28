using System;

namespace TennisKata
{
    public class TennisGame
    {
        private int _player1ScoreTimes;

        public string ShowScore()
        {
            if (this._player1ScoreTimes > 0)
            {
                return "Fifteen Love";
            }

            return "Love All";
        }

        public void Player1Score()
        {
            this._player1ScoreTimes++;
        }
    }
}