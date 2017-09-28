namespace TennisKata
{
    public class TennisGame
    {
        private int _player1ScoreTimes;

        public string ShowScore()
        {
            if (this._player1ScoreTimes > 0)
            {
                var player1Score = GetPlayer1Score();

                return player1Score + " Love";
            }

            return "Love All";
        }

        private string GetPlayer1Score()
        {
            var player1Score = "";
            if (this._player1ScoreTimes == 1)
            {
                player1Score = "Fifteen";
            }
            else if (this._player1ScoreTimes == 2)
            {
                player1Score = "Thirty";
            }
            else if (this._player1ScoreTimes == 3)
            {
                player1Score = "Forty";
            }
            return player1Score;
        }

        public void Player1Score()
        {
            this._player1ScoreTimes++;
        }

        public void Player2Score()
        {
            throw new System.NotImplementedException();
        }
    }
}