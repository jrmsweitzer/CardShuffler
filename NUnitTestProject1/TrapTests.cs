using SDO.Models.Yugioh.Phases;
using SDO.Models.Yugioh.YugiohCards;
using SDO.Models.Yugioh.YugiohCardTypes;
using NUnit.Framework;
using System.Linq;

namespace Tests.Traps
{
    public class TrapTests: TestBase
    {
        [Test]
        public void CannotActivateOnTurnSet()
        {
            Game.TurnPlayer = Mai;
            Game.Turn = 3;

            var windstorm = Mai.Deck.AddCardToHand(Mai.Hand, "Windstorm of Etaqua");

            //new MainPhase1(Game).SetTrap(windstorm);
            //Assert.False(windstorm.CanActivate(), "Windstorm should not be able to activate on the turn it has been set.");
        }

        [Test]
        public void CannotActivateWindstormIfOpponentHasNoMonsters()
        {
            Game.TurnPlayer = Mai;
            Game.Turn = 3;

            var windstorm = (Trap)Mai.Deck.AddCardToHand(Mai.Hand, "Windstorm of Etaqua");

            new MainPhase1(Game).SetTrap(windstorm);
            Game.Turn = 4;
            Assert.False(windstorm.CanActivate(), "Windstorm should not be able to activate if the opponent has no monsters.");
        }

        [Test]
        public void CannotActivateWindstormIfOpponentHasNoFaceupMonsters()
        {
            Game.TurnPlayer = Mai;
            Game.Turn = 3;

            var windstorm = (Trap)Mai.Deck.AddCardToHand(Mai.Hand, "Windstorm of Etaqua");

            new MainPhase1(Game).SetTrap(windstorm);

            Game.TurnPlayer = Kaiba;
            Game.Turn = 4;

            var lordOfD = (Monster)Kaiba.Deck.AddCardToHand(Kaiba.Hand, "Lord of D.");

            new MainPhase1(Game).NormalSetWithoutTribute(lordOfD);
            Assert.False(windstorm.CanActivate(), "Windstorm should not be able to activate if the opponent has no faceup monsters");
        }

        [Test]
        public void CanActivateWindstormIfOpponentHasFaceupMonsters()
        {
            Game.TurnPlayer = Mai;
            Game.Turn = 3;

            var windstorm = (Trap)Mai.Deck.AddCardToHand(Mai.Hand, "Windstorm of Etaqua");

            new MainPhase1(Game).SetTrap(windstorm);

            Game.TurnPlayer = Kaiba;
            Game.Turn = 4;

            var lordOfD = (Monster)Kaiba.Deck.AddCardToHand(Kaiba.Hand, "Lord of D.");

            new MainPhase1(Game).NormalSummonWithoutTribute(lordOfD);
            Assert.True(windstorm.CanActivate(), "Windstorm should be able to activate (it was set last turn, kaiba just summoned Lord of D.)");
        }
    }
}
