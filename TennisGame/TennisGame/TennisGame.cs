using System;
using System.Collections.Generic;

namespace TennisGame
{
    public class TennisGame : ITennisGame
    {
        private int _firstPlayerScore;
        private int _secondPlayerScore;
        private string _firstPlayer;
        private string _secondPlayer;

        private Dictionary<int, string> _lookupDictionary = new Dictionary<int, string>()
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
            if (_firstPlayerScore != _secondPlayerScore)
            {
                if (IsAnyScoreGreaterThan3())
                {
                    if (IsAdvantage())
                    {
                        return GetAdvantage();
                    }
                    return GetWinner();
                }
                return GetNormalScore(_lookupDictionary);
            }

            return IsDeuce() ? GetDeuce() : GetAll(_lookupDictionary);
        }

        private string GetNormalScore(Dictionary<int, string> lookupDictionary)
        {
            return $"{lookupDictionary[_firstPlayerScore]} {_lookupDictionary[_secondPlayerScore]}";
        }

        private bool IsAnyScoreGreaterThan3()
        {
            return _firstPlayerScore > 3 || _secondPlayerScore > 3;
        }

        private string GetAdvantage()
        {
            if (_firstPlayerScore > _secondPlayerScore)
            {
                return $"{_firstPlayer} Adv";
            }
            else
            {
                return $"{_secondPlayer} Adv";
            }
        }

        private bool IsAdvantage()
        {
            return Math.Abs(_firstPlayerScore - _secondPlayerScore) == 1;
        }

        private string GetWinner()
        {
            if (_firstPlayerScore > _secondPlayerScore)
            {
                return $"{_firstPlayer} Win";
            }
            else
            {
                return $"{_secondPlayer} Win";
            }
        }

        private string GetAll(Dictionary<int, string> lookupDictionary)
        {
            return $"{lookupDictionary[_firstPlayerScore]} All";
        }

        private string GetDeuce()
        {
            return "Deuce";
        }

        private bool IsDeuce()
        {
            return _firstPlayerScore >= 3;
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
