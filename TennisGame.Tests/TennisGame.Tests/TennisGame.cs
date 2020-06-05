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
            if(_firstPlayerScore == 1)
            {
                return "Fiften Love";
            }
            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }
    }
}
