using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisKata
{
    [TestClass]
    public class TennisGameTests
    {
        private const string FirstPlayerName = "Joey";
        private const string SecondPlayerName = "Mary";
        private TennisGame tennisGame;

        [TestInitialize]
        public void TestInit()
        {
            this.tennisGame = new TennisGame(FirstPlayerName, SecondPlayerName);
        }

        [TestMethod]
        public void Love_All()
        {
            ScoreShouldBe("Love All");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            SetPlayer1ScoreTimes(1);
            ScoreShouldBe("Fifteen Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            SetPlayer1ScoreTimes(2);
            ScoreShouldBe("Thirty Love");
        }

        [TestMethod]
        public void Forty_Love()
        {
            SetPlayer1ScoreTimes(3);
            ScoreShouldBe("Forty Love");
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            SetPlayer2ScoreTimes(1);
            ScoreShouldBe("Love Fifteen");
        }

        [TestMethod]
        public void Love_Thirty()
        {
            SetPlayer2ScoreTimes(2);
            ScoreShouldBe("Love Thirty");
        }

        [TestMethod]
        public void Love_Forty()
        {
            SetPlayer2ScoreTimes(3);
            ScoreShouldBe("Love Forty");
        }

        [TestMethod]
        public void Fifteen_All()
        {
            SetPlayer1ScoreTimes(1);
            SetPlayer2ScoreTimes(1);
            ScoreShouldBe("Fifteen All");
        }

        [TestMethod]
        public void Thirty_All()
        {
            SetPlayer1ScoreTimes(2);
            SetPlayer2ScoreTimes(2);
            ScoreShouldBe("Thirty All");
        }

        [TestMethod]
        public void FirstPlayer_Win()
        {
            SetPlayer1ScoreTimes(4);
            ScoreShouldBe("Joey Win");
        }

        [TestMethod]
        public void SecondPlayer_Win()
        {
            SetPlayer2ScoreTimes(4);
            ScoreShouldBe("Mary Win");
        }

        [TestMethod]
        public void Deuce_forty_forty()
        {
            SetPlayer1ScoreTimes(3);
            SetPlayer2ScoreTimes(3);
            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void Deuce_4_4()
        {
            SetPlayer1ScoreTimes(4);
            SetPlayer2ScoreTimes(4);
            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void FirstPlayer_adv_when_4_3()
        {
            SetPlayer1ScoreTimes(4);
            SetPlayer2ScoreTimes(3);
            ScoreShouldBe("Joey Adv");
        }

        [TestMethod]
        public void SecondPlayer_adv_when_3_4()
        {
            SetPlayer1ScoreTimes(3);
            SetPlayer2ScoreTimes(4);
            ScoreShouldBe("Mary Adv");
        }

        [Ignore]
        [TestMethod]
        public void Player1_Win_Aftere_Adv_5_3()
        {
            SetPlayer1ScoreTimes(5);
            SetPlayer2ScoreTimes(3);
            ScoreShouldBe("Joey Win");
        }

        private void SetPlayer2ScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                tennisGame.Player2Score();
            }
        }

        private void SetPlayer1ScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                tennisGame.Player1Score();
            }
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, tennisGame.ShowScore());
        }
    }
}