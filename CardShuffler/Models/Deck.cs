using CardShuffler.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace CardShuffler.Models
{
    public class Deck
    {
        public List<Card> Cards { get; set; } = new List<Card>();
        public string OwnerName { get; set; }

        /// <summary>
        /// Draws a card and adds it to the hand
        /// </summary>
        /// <param name="hand"></param>
        public Card DrawACardFromTop(Hand hand)
        {
            var card = Cards[0];
            card.Location = Yugioh.CardLocation.HandHidden;
            hand.Add(card);
            Cards.RemoveAt(0);
            return card;
        }

        /// <summary>
        /// Draws a card and adds it to the hand
        /// </summary>
        /// <param name="hand"></param>
        public void DrawACardFromBottom(Hand hand)
        {
            var index = Cards.Count() - 1;
            var card = Cards[index];
            card.Location = Yugioh.CardLocation.HandHidden;
            hand.Add(card);
            Cards.RemoveAt(index);
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
            var cardToAdd = Cards.FirstOrDefault(c => c.Name == cardName);
            cardToAdd.Location = Yugioh.CardLocation.HandHidden;
            Cards.Remove(cardToAdd);
            hand.Add(cardToAdd);
            return cardToAdd;
        }

        public Card AddCardToHand(Hand hand, Card card)
        {
            card.Location = Yugioh.CardLocation.HandHidden;
            Cards.Remove(card);
            hand.Add(card);
            return card;
        }

        public void Shuffle()
        {
            Cards = Cards.Shuffle();
        }

        public Deck Copy()
        {
            var deck = new Deck()
            {
                OwnerName = this.OwnerName,
                Cards = new List<Card>()
            };

            foreach (var card in Cards)
                deck.Cards.Add(card);

            return deck;
        }
    }
}
