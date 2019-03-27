using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace CardShuffler.Models
{
    public class GamePlayer
    {
        public string Name { get; set; }
        private Deck _deck { get; set; }
        public Deck Deck
        {
            get { return _deck; }
            set
            {
                _deck = value;
                for (int i = 0; i < _deck.Cards.Count; i++)
                {
                    _deck.Cards[i].Owner = this;
                }
            }
        }
        public Skill Skill { get; set; }
        public Hand Hand { get; set; } = new Hand();
        public List<Card> DiscardPile { get; set; } = new List<Card>();
        public List<Card> RemovedFromGame { get; set; } = new List<Card>();
        public Monster LastSuccessfulNormalSummon { get; set; }
        public GamePlayer Opponent { get; set; }

        public void DrawStartingHand(int handSize)
        {
            if (Deck == null) throw new NullReferenceException("Deck");
            var hand = Deck.DrawStartingHand(Hand, handSize);
            foreach (var card in hand)
                Console.WriteLine($"{Name} drew {card.Name}");
        }

        public void ShuffleDeck()
        {
            Deck.Shuffle();
        }
    }
}
