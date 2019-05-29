using SDO.Models.Yugioh;
using SDO.Models.Yugioh.Phases;
using SDO.Models.Yugioh.YugiohCardTypes;
using NUnit.Framework;

namespace Tests.CardSpecificTests.Traps
{
    public class CardSpecificTests: TestBase
    {
        [Test]
        public void WildTornadoCannotActivateIfOpponentHasNoSpellsOrTraps()
        {
            Mai.Deck = HarpieDeck;
            var tornado = (Trap)Mai.Deck.AddCardToHand(Mai.Hand, "Wild Tornado");
            Game.Turn = 1;
            new MainPhase1(Game).SetTrap(tornado);

            Assert.AreEqual(CardLocation.SpellTrapZone, tornado.Location);
            Assert.AreEqual(CardPosition.FaceDown, tornado.Position);

            Game.Turn = 2;
            //Assert.False(tornado.CanActivate());
        }

        [Test]
        public void WildTornadoCannotActivateIfOpponentHasNoFaceupSpellsOrTraps()
        {
            Mai.Deck = HarpieDeck;
            var tornado = (Trap)Mai.Deck.AddCardToHand(Mai.Hand, "Wild Tornado");
            Game.Turn = 1;
            new MainPhase1(Game).SetTrap(tornado);

            Assert.AreEqual(CardLocation.SpellTrapZone, tornado.Location);
            Assert.AreEqual(CardPosition.FaceDown, tornado.Position);

            Game.Turn = 2;
            Game.TurnPlayer = Kaiba;

            var windstorm = (Trap)Kaiba.Deck.AddCardToHand(Kaiba.Hand, "Windstorm of Etaqua");
            new MainPhase1(Game).SetTrap(windstorm);

            Assert.AreEqual(CardLocation.SpellTrapZone, windstorm.Location);
            Assert.AreEqual(CardPosition.FaceDown, windstorm.Position);

            //Assert.False(tornado.CanActivate());
        }

        [Test]
        public void WildTornadoCanActivateIfOpponentHasFaceUpSpellTrap()
        {
            Mai.Deck = HarpieDeck;
            var tornado = (Trap)Mai.Deck.AddCardToHand(Mai.Hand, "Wild Tornado");
            Game.Turn = 1;
            new MainPhase1(Game).SetTrap(tornado);

            Assert.AreEqual(CardLocation.SpellTrapZone, tornado.Location);
            Assert.AreEqual(CardPosition.FaceDown, tornado.Position);

            Game.Turn = 2;
            Game.TurnPlayer = Kaiba;
            Kaiba.Deck = ToonDeck;
            var toonWorld = (Spell)Kaiba.Deck.AddCardToHand(Kaiba.Hand, "Toon World");

            new MainPhase1(Game).ActivateSpell(toonWorld);

            Assert.AreEqual(CardLocation.SpellTrapZone, toonWorld.Location);
            Assert.AreEqual(CardPosition.FaceUp, toonWorld.Position);

            //Assert.True(tornado.CanActivate());
        }
    }
}
