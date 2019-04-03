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
            Assert.AreEqual(preshuffledDeck.Cards[0].Name, BlueEyes);
            Assert.AreEqual(preshuffledDeck.Cards[1].Name, BlueEyes);
            Assert.AreEqual(preshuffledDeck.Cards[2].Name, BlueEyes);

            var postShuffledDeck = BlueEyesDeck.Copy();
            postShuffledDeck.Shuffle();

            bool shuffled = false;
            for (int i = 0; i < postShuffledDeck.Cards.Count(); i++)
            {
                if (preshuffledDeck.Cards[i].Name != postShuffledDeck.Cards[i].Name)
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
            Assert.AreEqual(deck.Cards.Count(), 20);
            Assert.AreEqual(hand.Cards.Count(), 0);
            Assert.AreEqual(deck.Cards[0].Name, BlueEyes);
            Assert.AreEqual(deck.Cards[1].Name, BlueEyes);
            Assert.AreEqual(deck.Cards[2].Name, BlueEyes);

            // Gonna draw 3 cards
            deck.DrawStartingHand(hand, 3);

            // Should have 3 cards in hand.
            Assert.AreEqual(deck.Cards.Count(), 17);
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
            Assert.AreEqual(Kaiba.Deck.Cards.Count(), 20);
            Assert.AreEqual(Kaiba.Hand.Cards.Count(), 0);
            Assert.AreEqual(Mai.Deck.Cards.Count(), 20);
            Assert.AreEqual(Mai.Hand.Cards.Count(), 0);

            Game.Start();
            // After Start
            Assert.AreEqual(Kaiba.Deck.Cards.Count(), 16);
            Assert.AreEqual(Kaiba.Hand.Cards.Count(), 4);
            Assert.AreEqual(Mai.Deck.Cards.Count(), 16);
            Assert.AreEqual(Mai.Hand.Cards.Count(), 4);
            
        }
    }
}