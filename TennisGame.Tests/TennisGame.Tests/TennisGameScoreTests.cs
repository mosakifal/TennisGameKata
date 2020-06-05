using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGame.Tests
{
    [TestClass]
    public class TennisGameScoreTests
    {
        [TestMethod]
        public void TennisGame_Returns_Love_All()
        {
            var tennisGame = new TennisGame();

            var score = tennisGame.Score();

            Assert.AreEqual("Love All", score);
        }
    }
}
