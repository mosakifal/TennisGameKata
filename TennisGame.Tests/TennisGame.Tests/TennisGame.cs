using System;
using System.Collections.Generic;
using System.Text;

namespace TennisGame.Tests
{
    public class TennisGame
    {
        private int _firstPlayerScore;
        private int _secondPlayerScore;
        private string _firstPlayer;
        private string _secondPlayer;

        protected internal Dictionary<int, string> _lookupDictionary = new Dictionary<int, string>()
        {
            {0, "Love" }, {1, "Fifteen"}, {2, "Thirty"}, {3, "Forty"}
        };

        public TennisGame(string firstPlayer, string secondPlayer)
        {
            _firstPlayer = firstPlayer;
            _secondPlayer = secondPlayer;
        }

        public string Score()
        {
            if(_firstPlayerScore != _secondPlayerScore)
            {
                if (_firstPlayerScore > 3)
                {
                    if (_firstPlayerScore - _secondPlayerScore == 1)
                    {
                        return $"{_firstPlayer} Adv";
                    }
                }          
                return $"{_lookupDictionary[_firstPlayerScore]} {_lookupDictionary[_secondPlayerScore]}";
            }
            if(_firstPlayerScore >= 3)
            {
                return "Deuce";
            }
            return $"{_lookupDictionary[_firstPlayerScore]} All";
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
