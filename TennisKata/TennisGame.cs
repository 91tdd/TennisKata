namespace TennisKata
{
    public class TennisGame
    {
        private int _player1ScoreTimes;

        public string ShowScore()
        {
            if (this._player1ScoreTimes == 1)
            {
                return "Fifteen Love";
            }
            else if (this._player1ScoreTimes == 2)
            {
                return "Thirty Love" ;
            }

            return "Love All";
        }

        public void Player1Score()
        {
            this._player1ScoreTimes++;
        }
    }
}