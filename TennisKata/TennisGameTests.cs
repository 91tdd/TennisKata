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
            tennisGame.Player1Score();
            ScoreShouldBe("Fifteen Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            tennisGame.Player1Score();
            tennisGame.Player1Score();
            ScoreShouldBe("Thirty Love");
        }
        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, tennisGame.ShowScore());
        }
    }
}