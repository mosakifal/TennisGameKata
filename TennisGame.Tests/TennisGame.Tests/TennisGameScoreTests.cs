using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            Assert.AreEqual("Fiften Love", _tennisGame.Score());
        }
    }
}
