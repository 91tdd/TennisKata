using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisKata
{
    [TestClass]
    public class TennisGameTests
    {
        private TennisGame tennisGame = new TennisGame();

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
            tennisGame.Player2Score();
            ScoreShouldBe("Love Fifteen");
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