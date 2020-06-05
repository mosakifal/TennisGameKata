using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TennisGame.Tests
{
    [TestClass]
    public class TennisGameScoreTests
    {
        protected internal TennisGame _tennisGame = new TennisGame("Mo", "James");

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
            GiveSecondPlayerScore(1);
            ScoreShouldbe("Love Fifteen");
        }

        private void GiveSecondPlayerScore(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennisGame.SecondPlayerScore();
            }
        }

        [TestMethod]
        public void TennisGame_Returns_Love_Thirty()
        {
            GiveSecondPlayerScore(2);
            ScoreShouldbe("Love Thirty");
        }

        [TestMethod]
        public void TennisGame_Returns_Fifteen_All()
        {
            GiveFirstPlayerScore(1);
            GiveSecondPlayerScore(1);
            ScoreShouldbe("Fifteen All");
        }

        [TestMethod]
        public void TennisGame_Returns_Thirty_All()
        {
            GiveFirstPlayerScore(2);
            GiveSecondPlayerScore(2);
            ScoreShouldbe("Thirty All");
        }

        [TestMethod]
        public void TennisGame_Returns_Deuce()
        {
            GiveFirstPlayerScore(3);
            GiveSecondPlayerScore(3);
            ScoreShouldbe("Deuce");
        }

        [TestMethod]
        public void TennisGame_Returns_FirstPlayer_Adv()
        {
            GiveFirstPlayerScore(4);
            GiveSecondPlayerScore(3);
            ScoreShouldbe("Mo Adv");
        }

        [TestMethod]
        public void TennisGame_Returns_SecondPlayer_Adv()
        {
            GiveFirstPlayerScore(3);
            GiveSecondPlayerScore(4);
            ScoreShouldbe("James Adv");
        }

        [TestMethod]
        public void TennisGame_Returns_Deuce_4()
        {
            GiveFirstPlayerScore(4);
            GiveSecondPlayerScore(4);
            ScoreShouldbe("Deuce");
        }
    }
}
