using CardShuffler.Models.Yugioh.Phases;
using CardShuffler.Models.Yugioh.YugiohCards;
using CardShuffler.Models.Yugioh.YugiohCardTypes;
using NUnit.Framework;

namespace Tests.SkillTests
{
    public class DragonCallerTests : TestBase
    {
        [Test]
        public void DragonCaller_FirstSkill()
        {
            Game.TurnPlayer = Kaiba;
            var dragonCaller = new DragonCaller(Game);
            Kaiba.Skill = dragonCaller;

            var lordOfD = (Monster)Kaiba.Deck.AddCardToHand(Kaiba.Hand, "Lord of D.");
            var legalTargets = dragonCaller.GetLegalTargetsForFirstSkill();

            Assert.AreEqual(2, dragonCaller.SkillCount);
            Assert.AreEqual(3, legalTargets.Count);
            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);

            // Haven't normal summoned yet
            Assert.False(dragonCaller.CanActivateFirstSkill());
            var success = dragonCaller.ExecuteSecondSkill(legalTargets[0]);
            Assert.False(success);

            new MainPhase1(Game).NormalSummonWithoutTribute(lordOfD);

            Assert.True(dragonCaller.CanActivateFirstSkill());
            success = dragonCaller.ExecuteFirstSkill(legalTargets[0]);
            Assert.True(success);
            Assert.False(dragonCaller.CanActivateSecondSkill());
            Assert.False(dragonCaller.CanActivateFirstSkill());
            Assert.True(Kaiba.Hand.Cards.Contains(legalTargets[0]));
        }

        [Test]
        public void DragonCaller_SecondSkill()
        {
            Game.TurnPlayer = Kaiba;
            var dragonCaller = new DragonCaller(Game);
            Kaiba.Skill = dragonCaller;

            var flute = (Spell)Kaiba.Deck.AddCardToHand(Kaiba.Hand, "The Flute of Summoning Dragon");
            var legalTargets = dragonCaller.GetLegalTargetsForSecondSkill();

            Assert.AreEqual(2, dragonCaller.SkillCount);
            Assert.True(dragonCaller.CanActivateSecondSkill());
            Assert.AreEqual(3, legalTargets.Count);
            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);

            var success = dragonCaller.ExecuteSecondSkill(legalTargets[0]);
            Assert.True(success);
            Assert.False(dragonCaller.CanActivateSecondSkill());
            Assert.False(dragonCaller.CanActivateFirstSkill());
            Assert.True(Kaiba.Hand.Cards.Contains(legalTargets[0]));
        }
    }
}
