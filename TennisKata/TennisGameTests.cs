using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisKata
{
    [TestClass]
    public class TennisGameTests
    {
        [TestMethod]
        public void Love_All()
        {
            var tennisGame = new TennisGame();
            string result = tennisGame.ShowScore();
            Assert.AreEqual("Love All", result);
        }
    }

    public class TennisGame
    {
        public string ShowScore()
        {
            throw new NotImplementedException();
        }
    }
}
