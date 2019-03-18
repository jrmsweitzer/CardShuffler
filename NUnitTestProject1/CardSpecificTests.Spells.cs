using CardShuffler.Models.Yugioh;
using CardShuffler.Models.Yugioh.Phases;
using CardShuffler.Models.Yugioh.YugiohCardTypes;
using NUnit.Framework;
using System.Linq;

namespace Tests.CardSpecificTests.Spells
{
    public class CardSpecificTests: TestBase
    {
        public CardSpecificTests()
        {
        }

        [Test]
        public void CanActivateFluteIfLegal()
        {
            var lordOfD = (Monster)Kaiba.Deck.AddCardToHand(Kaiba.Hand, "Lord of D.");
            var flute = (Spell)Kaiba.Deck.AddCardToHand(Kaiba.Hand, "The Flute of Summoning Dragon");
            var bewd = (Monster)Kaiba.Deck.AddCardToHand(Kaiba.Hand, "Blue-Eyes White Dragon");
            var tdragon = (Monster)Kaiba.Deck.AddCardToHand(Kaiba.Hand, "Tyrant Dragon");

            Assert.AreEqual(4, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            Assert.AreEqual(0, Kaiba.Field.SpellTrapZones.Where(z => z.SpellTrapCard != null).Count());
            Assert.AreEqual(0, Kaiba.Field.MonsterZones.Where(z => z.Monster != null).Count());

            var mp = new MainPhase1(Game);

            mp.NormalSetWithoutTribute(lordOfD);
            var success = mp.ActivateSpell(flute, bewd, tdragon);

            Assert.True(success);
            Assert.AreEqual(0, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(1, Kaiba.DiscardPile.Count);
            Assert.AreEqual(0, Kaiba.Field.SpellTrapZones.Where(z => z.SpellTrapCard != null).Count());
            Assert.AreEqual(3, Kaiba.Field.MonsterZones.Where(z => z.Monster != null).Count());
        }

        [Test]
        public void AmazonessVillageShouldBoostAmazonessMonsters()
        {
            var village = (Spell)Mai.Deck.AddCardToHand(Mai.Hand, "Amazoness Village");
            var swordsWoman = (Monster)Mai.Deck.AddCardToHand(Mai.Hand, "Amazoness Swords Woman");

            Game.TurnPlayer = Mai;

            var m1 = new MainPhase1(Game);
            m1.ActivateSpell(village);
            m1.NormalSummonWithoutTribute(swordsWoman);

            Assert.IsTrue(Mai.Field.FieldZone.FieldSpell == village, "Mai should have Amazoness Village active in the field spell zone.");
            Assert.AreEqual(1, Game.FieldBuffs.Count, "Mai should have 1 field buff");
            Assert.AreEqual(CardLocation.MonsterZoneFaceUpAttack, swordsWoman.Location, "Swordswoman should be in face-up attack position.");
            Assert.AreEqual(1700, swordsWoman.ATK, "Swordswoman should have 1700 ATK");
        }
    }
}
