using System;
using System.Collections.Generic;

namespace hilo_game.Game
{
    public class Director {
        public Director()
        {
        }

        public void Test()
        {
            Console.WriteLine("Director Working");
        }
        public void StartGame()
        {
            Score score = new Score();
            score.Test();

            Card card = new Card();
            card.Test();
        }
        
    }
}