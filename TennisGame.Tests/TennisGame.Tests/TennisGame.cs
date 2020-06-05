using System;
using System.Collections.Generic;
using System.Text;

namespace TennisGame.Tests
{
    public class TennisGame
    {
        private int _firstPlayerScore;

        public string Score()
        {
            var lookupDictionary = new Dictionary<int, string>()
            {
                {0, "Love" }, {1, "Fifteen"}, {2, "Thirty"}
            };

            if(_firstPlayerScore > 0)
            {
                return $"{lookupDictionary[_firstPlayerScore]} Love";
            }

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }
    }
}
