using SDO.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SDO.Models
{
    public class Deck
    {
        public List<Card> MainDeckCards { get; set; } = new List<Card>();
        public List<Card> SideDeckCards { get; set; } = new List<Card>();
        public List<Card> FusionDeckCards { get; set; } = new List<Card>();
        public string OwnerName { get; set; }

        /// <summary>
        /// Draws a card and adds it to the hand
        /// </summary>
        /// <param name="hand"></param>
        public Card DrawACardFromTop(Hand hand)
        {
            var card = MainDeckCards[0];
            card.Location = Yugioh.CardLocation.Hand;
            hand.Add(card);
            MainDeckCards.RemoveAt(0);
            return card;
        }

        /// <summary>
        /// Draws a card and adds it to the hand
        /// </summary>
        /// <param name="hand"></param>
        public void DrawACardFromBottom(Hand hand)
        {
            var index = MainDeckCards.Count() - 1;
            var card = MainDeckCards[index];
            card.Location = Yugioh.CardLocation.Hand;
            hand.Add(card);
            MainDeckCards.RemoveAt(index);
        }

        public List<Card> DrawStartingHand(Hand hand, int startingHandSize)
        {
            var list = new List<Card>();
            for (int i = 1; i <= startingHandSize; i++)
            {
                list.Add(DrawACardFromTop(hand));
            }
            return list;
        }

        public Card AddCardToHand(Hand hand, string cardName)
        {
            var cardToAdd = MainDeckCards.FirstOrDefault(c => c.Name == cardName);
            if (cardToAdd == null)
                throw new Exception("Cannot find card by name " + cardName);
            cardToAdd.Location = Yugioh.CardLocation.Hand;
            MainDeckCards.Remove(cardToAdd);
            hand.Add(cardToAdd);
            return cardToAdd;
        }

        public Card AddCardToHand(Hand hand, Card card)
        {
            card.Location = Yugioh.CardLocation.Hand;
            MainDeckCards.Remove(card);
            hand.Add(card);
            return card;
        }

        public void Shuffle()
        {
            MainDeckCards = MainDeckCards.Shuffle();
        }

        public Deck Copy()
        {
            var deck = new Deck()
            {
                OwnerName = this.OwnerName,
                MainDeckCards = new List<Card>()
            };

            foreach (var card in MainDeckCards)
                deck.MainDeckCards.Add(card);

            return deck;
        }
    }
}
