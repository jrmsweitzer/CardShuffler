using CardShuffler.Models.Yugioh;
using CardShuffler.Models.Yugioh.Phases;
using CardShuffler.Models.Yugioh.YugiohCardTypes;
using NUnit.Framework;
using System.Linq;
using Tests;

namespace Tests.CardSpecificTests.Monsters
{
    public class CardSpecificTests: TestBase
    {
        [Test]
        public void HarpieLadyBoostShouldApplyToSelfOnSummon()
        {
            Game.TurnPlayer = Mai;
            var harpieLady = (Monster)GetCardByName("Harpie Lady 1");

            Mai.Hand.Cards.Add(harpieLady);
            Assert.AreEqual(1, Mai.Hand.Cards.Count);
            Assert.AreEqual(1300, harpieLady.ATK);
            Assert.AreEqual(1300, ((Monster)Mai.Hand.Cards[0]).ATK);

            new MainPhase1(Game).NormalSummonWithoutTribute(harpieLady);
            Assert.AreEqual(0, Mai.Hand.Cards.Count);
            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(1600, harpieLady.ATK);
        }

        [Test]
        public void HarpieLadyBoostShouldApplyToWINDMonsersOnSummon()
        {
            Game.TurnPlayer = Mai;
            Mai.Deck = HarpieDeck;
            var harpieLady = (Monster)Mai.Deck.AddCardToHand(Mai.Hand, "Harpie Lady 1");
            var birdface = (Monster)Mai.Deck.AddCardToHand(Mai.Hand, "Birdface");

            new MainPhase1(Game).NormalSummonWithoutTribute(birdface);

            // before summon of harpie
            Assert.IsTrue(Mai.Field.MonsterZones.Any(zone => zone.Monster == birdface), "Birdface should be on Mai's field, in a monster zone");
            Assert.AreEqual(CardLocation.MonsterZoneFaceUpAttack, birdface.Location, "Birdface should be in face-up attack position");
            Assert.AreEqual(1600, Mai.Field.GetMonsters()[0].ATK, "Birdface should have 1600 ATK");
            Assert.AreEqual(1, Mai.Hand.Cards.Count, "Mai should have 1 card in hand.");
            Assert.IsTrue(Mai.Hand.Cards.Contains(harpieLady), "Mai should have Harpie Lady in hand.");

            new MainPhase1(Game).NormalSummonWithoutTribute(harpieLady);

            // After summon
            Assert.AreEqual(0, Mai.Hand.Cards.Count);
            Assert.AreEqual(2, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(1, Game.FieldBuffs.Count);
            Assert.AreEqual("Birdface", Mai.Field.GetMonsters()[0].Name);
            Assert.AreEqual(1900, Mai.Field.GetMonsters()[0].ATK);
            Assert.AreEqual("Harpie Lady 1", Mai.Field.GetMonsters()[1].Name);
            Assert.AreEqual(1600, Mai.Field.GetMonsters()[1].ATK);
        }

        [Test]
        public void HarpieLadyBoostsShouldStack()
        {
            Game.TurnPlayer = Mai;
            Mai.Deck = HarpieDeck;

            var firstHarpie = (Monster)Mai.Deck.AddCardToHand(Mai.Hand, "Harpie Lady 1");
            var secondHarpie = (Monster)Mai.Deck.AddCardToHand(Mai.Hand, "Harpie Lady 1");

            // Normal summon first
            new MainPhase1(Game).NormalSummonWithoutTribute(firstHarpie);

            // first should be buffed, second, not yet
            Assert.AreEqual(CardLocation.MonsterZoneFaceUpAttack, firstHarpie.Location, "First Harpie should be on the field.");
            Assert.AreEqual(1, Game.FieldBuffs.Count);
            Assert.AreEqual(1600, firstHarpie.ATK, "Harpie on field should have 1600 ATK.");
            Assert.AreEqual(CardLocation.HandHidden, secondHarpie.Location, "Second Harpie should still be in the hand.");
            Assert.AreEqual(1300, secondHarpie.ATK, "Harpie in hand should only have 1300 ATK.");

            // Normal summon second
            new MainPhase1(Game).NormalSummonWithoutTribute(secondHarpie);

            // they should buff each other
            Assert.AreEqual(1900, firstHarpie.ATK, "First Harpie should gain both boosts.");
            Assert.AreEqual(1900, secondHarpie.ATK, "Second Harpie should gain both boosts.");
        }
    }
}
