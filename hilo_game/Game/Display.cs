using System;
using System.Collections.Generic;

namespace hilo_game.Game
{
    
    public class Display
    {
        //Variables
        public int _pointsCorrect;
        public int _pointsWrong;
        public int _numCards;
        public int _score;

        //Constructor
        public Display()
        {
            _pointsCorrect = 0;
            _pointsWrong = 0;
            _numCards = 0;
            _score = 0;
        }

        //"Intro" diplays intro message
        public void Intro()
        {
            Console.WriteLine("\n----- Hi-Lo Game -----\n");

            Console.WriteLine("RULES:");
            Console.WriteLine($"You have been given a deck of cards numbered 1 through {_numCards}.");
            Console.WriteLine("Each turn, you will be given a new card. Your job is to guess");
            Console.WriteLine("whether the next card drawn will be higher or lower than the");
            Console.WriteLine("current card.\n");
            Console.WriteLine($"If your guess is right, you get {_pointsCorrect} points.");
            Console.WriteLine($"Guess wrong, and you lose {_pointsWrong} points.");
            Console.WriteLine($"You will being with {_score} points.");
            Console.WriteLine("If your score drops to zero, the game is over.\n");
            Console.WriteLine("Good Luck!\n");
        }

        //"CorrectMsg" displays a message that tells user that their guess was correct along with the number of points earned
        public void CorrectMsg()
        {
            Console.WriteLine($"\nCORRECT! :)\n+{_pointsCorrect} Points\n");
        }

        //"WrongMsg" displays a message that tells user that their guess was wrong along with the number of points lost
        public void WrongMsg()
        {
            Console.WriteLine($"\nWrong :(\n-{_pointsWrong} Points\n");
        }

        //"GameOverMsg" displays a game over message
        public void GameOverMsg()
        {
            Console.WriteLine("\n~~~~~~~~~\nGAME OVER\n~~~~~~~~~\n");
        }

        //"EndMsg" displays a message that appears at the end of the game
        public void EndMsg()
        {
            Console.WriteLine("Have a nice day! =)");
        }
    }
}