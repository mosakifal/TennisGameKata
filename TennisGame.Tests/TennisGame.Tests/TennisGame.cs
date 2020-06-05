using System;
using System.Collections.Generic;
using System.Text;

namespace TennisGame.Tests
{
    public class TennisGame
    {
        private int _firstPlayerScore;
        private int _secondPlayerScore;

        protected internal Dictionary<int, string> _lookupDictionary = new Dictionary<int, string>()
        {
            {0, "Love" }, {1, "Fifteen"}, {2, "Thirty"}, {3, "Forty"}
        };

        public string Score()
        {
            if(_firstPlayerScore != _secondPlayerScore)
            {
                return $"{_lookupDictionary[_firstPlayerScore]} {_lookupDictionary[_secondPlayerScore]}";
            }
            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScore++;
        }
    }
}
