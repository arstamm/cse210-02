using System;
using System.Collections.Generic;

namespace hilo_game.Game
{
    //This program contains the logic for the game
    public class Director
    {
        //Constants
        private const int CorrectDefault = 100;
        private const int WrongDefault = 75;
        private const int NumCardDefault = 13;
        private const int ScoreDefault = 300;

        //Variables
        Deck deck = new Deck();
        Score score = new Score();
        Display display = new Display();
        static string response = "";

        //Constructor
        public Director()
        {
            deck.SetRange(NumCardDefault);
            score.SetDefault(ScoreDefault);
            display._pointsCorrect = CorrectDefault;
            display._pointsWrong = WrongDefault;
            display._numCards = NumCardDefault;
            display._score = ScoreDefault;
        }

        //"StartGame" starts the Hilo game loop 
        public void StartGame()
        {
            //Intro
            display.Intro();

            //Game Loop
            deck.Shuffle();
            deck.Draw();
            score.Display();
            while (true)
            {   
                //Display card and ask player for guess
                Console.WriteLine($"The card is: {deck.TopCard}");
                Console.WriteLine($"Higher or Lower? [h/l] ");
                response = Console.ReadLine();

                //Determine if guess is correct
                if (deck.TopCard < deck.NextCard && response.ToLower() == "h" || deck.TopCard > deck.NextCard && response.ToLower() == "l")
                {
                    score.Add(CorrectDefault);
                    display.CorrectMsg();
                }
                else
                {
                    score.Add(-WrongDefault);
                    display.WrongMsg();
                }

                //Display the Next Card and the current score
                Console.WriteLine($"The next card was: {deck.NextCard}");
                score.Display();

                //Check if score is Zero
                if (score.IsZero())
                {
                    //If score is Zero, the player gets a game over
                    display.GameOverMsg();
                    Console.WriteLine("Try again? [y/n] ");
                    response = Console.ReadLine();
                    if (response.ToLower() != "y")
                    {
                        break;
                    }
                    deck.Shuffle();
                    deck.Draw();
                    score.Reset();
                    score.Display();
                }
                else
                {
                    //Game play continues and a new card is drawn for the next repetition.
                    Console.WriteLine("Play Again? [y/n] ");
                    response = Console.ReadLine();
                    if (response.ToLower() != "y")
                    {
                        break;
                    }
                    deck.Draw();
                }
            }
            //End Message
            display.EndMsg();
        }        
    }
}