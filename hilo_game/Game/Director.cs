using System;
using System.Collections.Generic;

namespace hilo_game.Game
{
    public class Director {
        public Director()
        {
        }
        public void StartGame()
        {
            //Objects
            Deck deck = new Deck();
            Score score = new Score();
            Display display = new Display();

            //Intro
            display.Intro();

            //Game
            string response;
            deck.Shuffle();
            deck.Draw();
            score.Display();
            while (true)
            {   
                Console.WriteLine($"The card is: {deck.TopCard}");
                Console.WriteLine($"Higher or Lower? [h/l] ");
                response = Console.ReadLine();
                if (deck.TopCard < deck.NextCard && response.ToLower() == "h" || deck.TopCard > deck.NextCard && response.ToLower() == "l")
                {
                    score.Add(100);
                    display.CorrectMsg();
                }
                else
                {
                    score.Add(-75);
                    display.WrongMsg();
                }
                Console.WriteLine($"The next card was: {deck.NextCard}");
                score.Display();
                if (score.IsZero())
                {
                    display.GameOverMsg();
                    break;
                }
                Console.WriteLine("Play Again? [y/n] ");
                response = Console.ReadLine();
                if (response.ToLower() != "y")
                {
                    break;
                }
                deck.Draw();
                // Set up for Next Repeat
                if (deck.IsEmpty())
                {
                    deck.ShuffleAndContinue();
                }
            }
            //End Message
            display.EndMsg();
        }        
    }
}