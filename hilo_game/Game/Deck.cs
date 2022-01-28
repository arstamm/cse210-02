using System;
using System.Collections.Generic;

namespace hilo_game.Game
{
    public class Deck
    {
        // Variables
        private const int DefaultRange = 13;
        static List<int> _drawPile = new List<int>();
        static List<int> _discardPile = new List<int>();
        static int _range;

        //Properties
        public int TopCard 
        {
            get {return _discardPile[_discardPile.Count - 1];}
        }
        public int NextCard
        {
            get {return _drawPile[_drawPile.Count - 1];}
        }

        //Constructor
        public Deck()
        {
            SetRange(DefaultRange);
        }

        //Behaviors
        public void Reset()
        {   
            //Clear Deck
            _drawPile.Clear();
            _discardPile.Clear();

            //Add cards _drawPile ranging from 1 to the specified range
            for (int i = 1; i <= _range; i++)
            {
                _drawPile.Add(i);
            }
        }
        public void SetRange(int range)
        {
            //Set new range and reset Deck
            _range = range;
            Reset();
        }
        public void Shuffle()
        {   
            //Reset deck
            Reset();

            //Variables
            List<int> _shufflePile = new List<int>();  
            Random random = new Random();
            int card;

            //Shuffle Cards
            while (_drawPile.Count != 0)
            {
                card = _drawPile[random.Next(_drawPile.Count)];
                _drawPile.Remove(card);
                _shufflePile.Add(card);
            }   
            //Add shuffled cards to Draw Pile
            _drawPile.AddRange(_shufflePile);

        }
        public void ShuffleAndContinue()
        {
            int card = TopCard;
            Shuffle();
            Draw(card);
        }
        public void Draw(int card = 0)
        {   
            if (card == 0)
            {
                card = _drawPile[_drawPile.Count - 1];
            }
            _discardPile.Add(card);
            _drawPile.Remove(card);
   
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
}