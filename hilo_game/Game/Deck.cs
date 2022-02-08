using System;
using System.Collections.Generic;

namespace hilo_game.Game
{
    //This class acts like a deck of cards for the game
    public class Deck
    {
        //Variables
        private List<int> _drawPile = new List<int>();
        private List<int> _discardPile = new List<int>();
        private int _range;

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
        public Deck() => SetRange(1);

        //Methods

        //"Reset" clears the deck and places cards into the draw pile according to the specified range
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

        //"SetRange" sets up the number of cards in the deck and resets the deck
        public void SetRange(int range)
        {
            //Set new range and reset Deck
            _range = range;
            Reset();
        }

        //"Shuffle" resets the deck and shuffles the cards around
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

        //"Draw" draws a new card
        //If the pile is empty, the deck reshuffles and all the cards are placed back in the deck with the exception of the newly drawn card.
        public void Draw()
        {   
            int card = NextCard;
            if (_drawPile.Count == 1)
            {
                Shuffle();
            }
            _drawPile.Remove(card);
            _discardPile.Add(card);
        }
    }
}