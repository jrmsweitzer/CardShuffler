using SDO.Models;
using NUnit.Framework;
using System.Linq;

namespace Tests.StartGameTests
{
    public class Tests: TestBase
    {
        public Deck GetShuffledDeck()
        {
            var deck = BlueEyesDeck;
            deck.Shuffle();
            return deck;
        }
        string BlueEyes = "Blue-Eyes White Dragon";

        [Test]
        public void ShuffleTest()
        {
            var preshuffledDeck = BlueEyesDeck;
            Assert.AreEqual(preshuffledDeck.MainDeckCards[0].Name, BlueEyes);
            Assert.AreEqual(preshuffledDeck.MainDeckCards[1].Name, BlueEyes);
            Assert.AreEqual(preshuffledDeck.MainDeckCards[2].Name, BlueEyes);

            var postShuffledDeck = BlueEyesDeck.Copy();
            postShuffledDeck.Shuffle();

            bool shuffled = false;
            for (int i = 0; i < postShuffledDeck.MainDeckCards.Count(); i++)
            {
                if (preshuffledDeck.MainDeckCards[i].Name != postShuffledDeck.MainDeckCards[i].Name)
                {
                    shuffled = true;
                    break;
                }
            }

            Assert.IsTrue(shuffled);
        }

        [Test]
        public void DrawUnshuffledStartingHand()
        {
            var deck = BlueEyesDeck;
            var hand = new Hand();
            // Should have no starting cards in hand.
            Assert.AreEqual(deck.MainDeckCards.Count(), 20);
            Assert.AreEqual(hand.Cards.Count(), 0);
            Assert.AreEqual(deck.MainDeckCards[0].Name, BlueEyes);
            Assert.AreEqual(deck.MainDeckCards[1].Name, BlueEyes);
            Assert.AreEqual(deck.MainDeckCards[2].Name, BlueEyes);

            // Gonna draw 3 cards
            deck.DrawStartingHand(hand, 3);

            // Should have 3 cards in hand.
            Assert.AreEqual(deck.MainDeckCards.Count(), 17);
            Assert.AreEqual(hand.Cards.Count(), 3);

            // Since we didn't shuffle, we know the order and which 3 we should have drawn
            Assert.AreEqual(hand.Cards[0].Name, BlueEyes);
            Assert.AreEqual(hand.Cards[1].Name, BlueEyes);
            Assert.AreEqual(hand.Cards[2].Name, BlueEyes);
        }

        [Test]
        public void StartNewYugiohGame()
        {
            // Before Start
            Assert.AreEqual(Kaiba.Deck.MainDeckCards.Count(), 20);
            Assert.AreEqual(Kaiba.Hand.Cards.Count(), 0);
            Assert.AreEqual(Mai.Deck.MainDeckCards.Count(), 20);
            Assert.AreEqual(Mai.Hand.Cards.Count(), 0);

            Game.Start();
            // After Start
            Assert.AreEqual(Kaiba.Deck.MainDeckCards.Count(), 16);
            Assert.AreEqual(Kaiba.Hand.Cards.Count(), 4);
            Assert.AreEqual(Mai.Deck.MainDeckCards.Count(), 16);
            Assert.AreEqual(Mai.Hand.Cards.Count(), 4);
            
        }
    }
}