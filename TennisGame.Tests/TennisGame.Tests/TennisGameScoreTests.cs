using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TennisGame.Tests
{
    [TestClass]
    public class TennisGameScoreTests
    {
        protected internal TennisGame _tennisGame = new TennisGame();

        [TestMethod]
        public void TennisGame_Returns_Love_All()
        {
            ScoreShouldbe("Love All");
        }

        private void ScoreShouldbe(string lookup)
        {
            Assert.AreEqual(lookup, _tennisGame.Score());
        }

        [TestMethod]
        public void TennisGame_Returns_Fifteen_Love()
        {
            _tennisGame.FirstPlayerScore();
            ScoreShouldbe("Fifteen Love");
        }

        [TestMethod]
        public void TennisGame_Returns_Thirty_Love()
        {
            GiveFirstPlayerScore(2);
            ScoreShouldbe("Thirty Love");
        }

        private void GiveFirstPlayerScore(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennisGame.FirstPlayerScore();
            }
        }

        [TestMethod]
        public void TennisGame_Returns_Forty_Love()
        {
            GiveFirstPlayerScore(3);
            ScoreShouldbe("Forty Love");
        }

        [TestMethod]
        public void TennisGame_Returns_Love_Fifteen()
        {
            _tennisGame.SecondPlayerScore();
            ScoreShouldbe("Love Fifteen");
        }
    }
}
