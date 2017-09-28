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
        public void FirstPlayer_Win()
        {
            SetPlayer1ScoreTimes(4);
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