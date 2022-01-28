using System;
using System.Collections.Generic;

namespace hilo_game.Game
{
    public class Deck
    {
        //states
        static List<int> _drawPile = new List<int>();
        static List<int> _discardPile = new List<int>();
        static List<int> _shufflePile = new List<int>();
        public Deck()
        {
        }

        //Behaviors

        public void SetRange(int range)
        {
            _drawPile.Clear();
            _discardPile.Clear();
            for (int i = 1; i <= range; i++)
            {
                _drawPile.Add(i);
            }
        }

        public int TopCard()
        {
            return 7;
        }
        public void Shuffle()
        {   
            //Set up Draw Piles
            _shufflePile.Clear();
            _shufflePile.AddRange(_drawPile);
            _shufflePile.AddRange(_discardPile);
            _drawPile.Clear();
            _discardPile.Clear();

            //Random Instance
            Random random = new Random();
            int card;

            //Shuffle numbers
            while (true)
                if (_shufflePile.Count == 0)
                {
                    break;
                }
                card = _shufflePile[random.Next(_shufflePile.Count)];
                _drawPile.Add(card);
                _shufflePile.Remove(card);

            

        }
        public void Draw()
        {
            
        }
        public bool IsEmpty()
        {
            if (_drawPile.Count == 0) 
            {
                return true;
            }
            else 
            {
                return false;
            }
            
        }

    }
    public class Score
    {
        //States
        int score;
        public Score()
        {
        }

        //Behaviors
        public void Display()
        {

        }

        public void Update()
        {

        }

        public void IsZero()
        {
            
        }
 


    }
    public class Display
    {

    }
}