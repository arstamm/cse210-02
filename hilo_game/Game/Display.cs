using System;
using System.Collections.Generic;

namespace hilo_game.Game
{
    
    public class Display
    {
        public Display()
        {
        }

        public void Intro()
        {
            Console.WriteLine("\n----- Hi-Lo Game -----\n");

            Console.WriteLine("RULES:");
            Console.WriteLine("You have been given a deck of cards numbered 1 through 13.");
            Console.WriteLine("Each turn, you will be given a new card. Your job is to guess");
            Console.WriteLine("whether the next card drawn will be higher or lower than the ");
            Console.WriteLine("current card.\n");
            Console.WriteLine("If your guess is right, you get 100 points.");
            Console.WriteLine("Guess wrong, and you lose 75 points.");
            Console.WriteLine("You will being with 300 points.");
            Console.WriteLine("If yoour score drops to zero, the game is over.\n");
            Console.WriteLine("Good Luck!\n");
        }

        public void CorrectMsg()
        {
            Console.WriteLine("\nCORRECT! :)\n+100 Points\n");
        }
        public void WrongMsg()
        {
            Console.WriteLine("\nWrong :(\n-75 Points\n");
        }
        public void GameOverMsg()
        {
            Console.WriteLine("\n~~~~~~~~~\nGAME OVER\n~~~~~~~~~\n");
        }
        public void EndMsg()
        {
            Console.WriteLine("Have a nice day! =)");
        }
    }
}