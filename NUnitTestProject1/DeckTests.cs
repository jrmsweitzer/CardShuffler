using SDO.Models.Yugioh.Phases;
using SDO.Models.Yugioh.YugiohCardTypes;
using NUnit.Framework;
using System.Linq;

namespace Tests.DeckTests
{
    public class DeckTests: TestBase
    {
        [Test]
        public void SearchDeckForCardByNameAndAddToHand()
        {
            Game.P1 = Pegasus;
            Game.TurnPlayer = Game.P1;
            Pegasus.Deck.AddCardToHand(Pegasus.Hand, "Toon Table of Contents");

            Assert.AreEqual(1, Pegasus.Hand.Cards.Count);
            Assert.AreEqual(0, Pegasus.DiscardPile.Count);
            Assert.AreEqual(19, Pegasus.Deck.MainDeckCards.Count);
            Assert.AreEqual(13, Pegasus.Deck.MainDeckCards.Where(c => c.Name.Contains("Toon")).Count());

            var toonTable = (Spell)Pegasus.Hand.Cards[0];

            //var legalTargets = toonTable.GetLegalTargets();
            //Assert.AreEqual(13, legalTargets.Count);

            var success = new MainPhase1(Game).ActivateSpell(toonTable, "Toon World");

            Assert.True(success);
            Assert.AreEqual(1, Pegasus.DiscardPile.Count);
            Assert.AreEqual("Toon Table of Contents", Pegasus.DiscardPile[0].Name);
            Assert.AreEqual(1, Pegasus.Hand.Cards.Count);
            Assert.AreEqual("Toon World", Pegasus.Hand.Cards[0].Name);
            Assert.AreEqual(18, Pegasus.Deck.MainDeckCards.Count);
        }

        [Test]
        public void CannotActivateSpellIfTargetIsNotValid()
        {
            Game.P1 = Pegasus;
            Game.TurnPlayer = Game.P1;
            Pegasus.Deck.AddCardToHand(Pegasus.Hand, "Toon Table of Contents");

            Assert.AreEqual(1, Pegasus.Hand.Cards.Count);
            Assert.AreEqual(0, Pegasus.DiscardPile.Count);
            Assert.AreEqual(19, Pegasus.Deck.MainDeckCards.Count);
            Assert.AreEqual(13, Pegasus.Deck.MainDeckCards.Where(c => c.Name.Contains("Toon")).Count());

            var toonTable = (Spell)Pegasus.Hand.Cards[0];
            var success = new MainPhase1(Game).ActivateSpell(toonTable, "Battle Ox");

            Assert.False(success);
            Assert.AreEqual(1, Pegasus.Hand.Cards.Count);
            Assert.AreEqual(0, Pegasus.DiscardPile.Count);
            Assert.AreEqual(19, Pegasus.Deck.MainDeckCards.Count);
            Assert.AreEqual(13, Pegasus.Deck.MainDeckCards.Where(c => c.Name.Contains("Toon")).Count());
        }

        [Test]
        public void CannotActivateSpellIfNoValidTargets()
        {
            Kaiba.Hand.Add(GetCardByName("Toon Table of Contents"));

            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            Assert.AreEqual(20, Kaiba.Deck.MainDeckCards.Count);
            Assert.AreEqual(0, Kaiba.Deck.MainDeckCards.Where(c => c.Name.Contains("Toon")).Count());

            var toonTable = (Spell)Kaiba.Hand.Cards[0];
            //var legalTargets = toonTable.GetLegalTargets();

            //Assert.AreEqual(0, legalTargets.Count);
            //Assert.False(toonTable.CanActivate());

            var success = new MainPhase1(Game).ActivateSpell(toonTable);

            Assert.False(success);
            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            Assert.AreEqual(20, Kaiba.Deck.MainDeckCards.Count);
            Assert.AreEqual(0, Kaiba.Deck.MainDeckCards.Where(c => c.Name.Contains("Toon")).Count());
        }

        [Test]
        public void ContinuousSpellsStayFaceup()
        {
            Game.P1 = Pegasus;
            Game.TurnPlayer = Game.P1;
            var toonWorld = (Spell)Pegasus.Deck.AddCardToHand(Pegasus.Hand, "Toon World");

            Assert.AreEqual(1, Pegasus.Hand.Cards.Count);
            Assert.AreEqual(0, Pegasus.DiscardPile.Count);
            Assert.AreEqual(0, Pegasus.Field.SpellTrapZones.Where(z => z.SpellTrapCard != null).Count());
            
            new MainPhase1(Game).ActivateSpell(toonWorld);

            Assert.AreEqual(0, Pegasus.Hand.Cards.Count);
            Assert.AreEqual(0, Pegasus.DiscardPile.Count);
            Assert.AreEqual(1, Pegasus.Field.SpellTrapZones.Where(z => z.SpellTrapCard != null).Count());
        }

        [Test]
        public void CannotActivateSpellIfAllZonesUsed()
        {
            Game.P1 = Pegasus;
            Game.TurnPlayer = Game.P1;
            var world1 = (Spell)Pegasus.Deck.AddCardToHand(Pegasus.Hand, "Toon World");
            var world2 = (Spell)Pegasus.Deck.AddCardToHand(Pegasus.Hand, "Toon World");
            var world3 = (Spell)Pegasus.Deck.AddCardToHand(Pegasus.Hand, "Toon World");
            var contents = (Spell)Pegasus.Deck.AddCardToHand(Pegasus.Hand, "Toon Table of Contents");

            Assert.AreEqual(4, Pegasus.Hand.Cards.Count);
            Assert.AreEqual(0, Pegasus.DiscardPile.Count);
            Assert.AreEqual(0, Pegasus.Field.SpellTrapZones.Where(z => z.SpellTrapCard != null).Count());

            var mp = new MainPhase1(Game);
            mp.ActivateSpell(world1);
            mp.ActivateSpell(world2);
            mp.ActivateSpell(world3);
            Assert.AreEqual(1000, Pegasus.LifePoints);
            Assert.AreEqual(1, Pegasus.Hand.Cards.Count);
            Assert.AreEqual(0, Pegasus.DiscardPile.Count);
            Assert.AreEqual(3, Pegasus.Field.SpellTrapZones.Where(z => z.SpellTrapCard != null).Count());

            var success = mp.ActivateSpell(contents);

            Assert.False(success);
            Assert.AreEqual(1, Pegasus.Hand.Cards.Count);
            Assert.AreEqual(0, Pegasus.DiscardPile.Count);
            Assert.AreEqual(3, Pegasus.Field.SpellTrapZones.Where(z => z.SpellTrapCard != null).Count());
        }
    }
}
