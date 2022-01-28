using System;
using System.Collections.Generic;

namespace hilo_game.Game
{
    public class Score
    {
        private const int DefaultScore = 300;

        //States
        static int _score;
        public Score()
        {
            _score = DefaultScore;
        }

        //Behaviors
        public void Display()
        {
            Console.WriteLine($"Current Score: {_score}");
        }
        public void Add(int points)
        {
            if (_score + points <= 0)
            {
                _score = 0;
            }
            else
            {
                _score += points;
            }

        }

        public bool IsZero()
        {
            if (_score == 0)
            {
                return true;
            }
            else
            {
                return false;
            }        
        }
    }
}