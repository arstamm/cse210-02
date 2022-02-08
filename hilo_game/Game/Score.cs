using System;
using System.Collections.Generic;

namespace hilo_game.Game
{
    //The "Score" class keeps track of the player's score
    public class Score
    {
        //Variables
        private int _score;
        private int _defaultScore;

        //Constructor
        public Score() => SetDefault(0);

        //Methods

        //"Display" displays the current score
        public void Display()
        {
            Console.WriteLine($"Current Score: {_score}");
        }
        
        //"SetDefault" sets a new default score and resets the current score
        public void SetDefault(int score)
        {
            _defaultScore = score;
            Reset();
        }

        //"Reset" sets the current score eqaul to the default score
        public void Reset()
        {
            _score = _defaultScore;
        }
        
        //"Add" adds to the current score. Value can be positive or negative.
        //This method will not allow the score to go below zero.
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

        //"IsZero" checks if the current score is zero.
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