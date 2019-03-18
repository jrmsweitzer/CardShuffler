using CardShuffler.Models.Yugioh.Phases;
using CardShuffler.Models.Yugioh.YugiohCardTypes;
using NUnit.Framework;

namespace Tests.BattlePhaseTests
{
    public class BattlePhaseTests: TestBase
    {
        [Test]
        public void HigherAttackAgainstLowerAttackShouldWin()
        {
            Kaiba.Field.MonsterZones[0].Monster = BattleOx;
            Kaiba.Field.MonsterZones[0].AttackPosition = true;
            Kaiba.Field.MonsterZones[0].FaceUp = true;

            Mai.Field.MonsterZones[0].Monster = AmazonessChainMaster;
            Mai.Field.MonsterZones[0].AttackPosition = true;
            Mai.Field.MonsterZones[0].FaceUp = true;

            Assert.AreEqual(1700, BattleOx.ATK);
            Assert.AreEqual(1500, AmazonessChainMaster.ATK);

            // before attack
            Assert.AreEqual(4000, Kaiba.LifePoints);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            Assert.AreEqual(4000, Mai.LifePoints);
            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(0, Mai.DiscardPile.Count);

            var battlePhase = new BattlePhase();
            battlePhase.Attack(Kaiba, BattleOx, Mai, AmazonessChainMaster);

            Assert.AreEqual(4000, Kaiba.LifePoints);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            Assert.AreEqual(3800, Mai.LifePoints);
            Assert.AreEqual(0, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(1, Mai.DiscardPile.Count);
        }

        [Test]
        public void LowerAttackAgainstHigherAttackShouldLose()
        {
            Kaiba.Field.MonsterZones[0].Monster = BattleOx;
            Kaiba.Field.MonsterZones[0].AttackPosition = true;
            Kaiba.Field.MonsterZones[0].FaceUp = true;

            Mai.Field.MonsterZones[0].Monster = AmazonessChainMaster;
            Mai.Field.MonsterZones[0].AttackPosition = true;
            Mai.Field.MonsterZones[0].FaceUp = true;

            Assert.AreEqual(1700, BattleOx.ATK);
            Assert.AreEqual(1500, AmazonessChainMaster.ATK);

            // before attack
            Assert.AreEqual(4000, Kaiba.LifePoints);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            Assert.AreEqual(4000, Mai.LifePoints);
            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(0, Mai.DiscardPile.Count);

            var battlePhase = new BattlePhase();
            battlePhase.Attack(Mai, AmazonessChainMaster, Kaiba, BattleOx);

            Assert.AreEqual(4000, Kaiba.LifePoints);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            Assert.AreEqual(3800, Mai.LifePoints);
            Assert.AreEqual(0, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(1, Mai.DiscardPile.Count);
        }

        [Test]
        public void EqualAttackAgainstEqualAttackShouldDestroyBoth()
        {
            Kaiba.Field.MonsterZones[0].Monster = TwinHeadedBehemoth;
            Kaiba.Field.MonsterZones[0].AttackPosition = true;
            Kaiba.Field.MonsterZones[0].FaceUp = true;

            Mai.Field.MonsterZones[0].Monster = AmazonessChainMaster;
            Mai.Field.MonsterZones[0].AttackPosition = true;
            Mai.Field.MonsterZones[0].FaceUp = true;

            Assert.AreEqual(1500, TwinHeadedBehemoth.ATK);
            Assert.AreEqual(1500, AmazonessChainMaster.ATK);

            // before attack
            Assert.AreEqual(4000, Kaiba.LifePoints);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            Assert.AreEqual(4000, Mai.LifePoints);
            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(0, Mai.DiscardPile.Count);

            var battlePhase = new BattlePhase();
            battlePhase.Attack(Mai, AmazonessChainMaster, Kaiba, TwinHeadedBehemoth);

            Assert.AreEqual(4000, Kaiba.LifePoints);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(1, Kaiba.DiscardPile.Count);
            Assert.AreEqual(4000, Mai.LifePoints);
            Assert.AreEqual(0, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(1, Mai.DiscardPile.Count);
        }

        [Test]
        public void LowerDefenseAgainstHigherDefenseShouldOnlyDealDamage()
        {
            Kaiba.Field.MonsterZones[0].Monster = TwinHeadedBehemoth;
            Kaiba.Field.MonsterZones[0].AttackPosition = true;
            Kaiba.Field.MonsterZones[0].FaceUp = true;

            Mai.Field.MonsterZones[0].Monster = AmazonessSwordsWoman;
            Mai.Field.MonsterZones[0].AttackPosition = false;
            Mai.Field.MonsterZones[0].FaceUp = true;

            Assert.AreEqual(1500, TwinHeadedBehemoth.ATK);
            Assert.AreEqual(1600, AmazonessSwordsWoman.DEF);

            // before attack
            Assert.AreEqual(4000, Kaiba.LifePoints);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            Assert.AreEqual(4000, Mai.LifePoints);
            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(0, Mai.DiscardPile.Count);

            var battlePhase = new BattlePhase();
            battlePhase.Attack(Kaiba, TwinHeadedBehemoth, Mai, AmazonessSwordsWoman);

            Assert.AreEqual(3900, Kaiba.LifePoints);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            Assert.AreEqual(4000, Mai.LifePoints);
            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(0, Mai.DiscardPile.Count);
        }

        [Test]
        public void HigherAttackAgianstLowerDefenseShouldWin()
        {
            Kaiba.Field.MonsterZones[0].Monster = BattleOx;
            Kaiba.Field.MonsterZones[0].AttackPosition = false;
            Kaiba.Field.MonsterZones[0].FaceUp = true;

            Mai.Field.MonsterZones[0].Monster = AmazonessSwordsWoman;
            Mai.Field.MonsterZones[0].AttackPosition = true;
            Mai.Field.MonsterZones[0].FaceUp = true;

            Assert.AreEqual(1000, BattleOx.DEF);
            Assert.AreEqual(1500, AmazonessSwordsWoman.ATK);

            // before attack
            Assert.AreEqual(4000, Kaiba.LifePoints);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            Assert.AreEqual(4000, Mai.LifePoints);
            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(0, Mai.DiscardPile.Count);

            var battlePhase = new BattlePhase();
            battlePhase.Attack(Mai, AmazonessSwordsWoman, Kaiba, BattleOx);

            Assert.AreEqual(4000, Kaiba.LifePoints);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(1, Kaiba.DiscardPile.Count);
            Assert.AreEqual(4000, Mai.LifePoints);
            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(0, Mai.DiscardPile.Count);
        }

        [Test]
        public void EqualAttackAgainstEqualDefenseShouldTie()
        {
            Kaiba.Field.MonsterZones[0].Monster = Birdface;
            Kaiba.Field.MonsterZones[0].AttackPosition = false;
            Kaiba.Field.MonsterZones[0].FaceUp = true;

            Mai.Field.MonsterZones[0].Monster = Birdface;
            Mai.Field.MonsterZones[0].AttackPosition = true;
            Mai.Field.MonsterZones[0].FaceUp = true;

            Assert.AreEqual(1600, Birdface.DEF);
            Assert.AreEqual(1600, Birdface.ATK);

            // before attack
            Assert.AreEqual(4000, Kaiba.LifePoints);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            Assert.AreEqual(4000, Mai.LifePoints);
            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(0, Mai.DiscardPile.Count);

            var battlePhase = new BattlePhase();
            battlePhase.Attack(Mai, Birdface, Kaiba, Birdface);

            Assert.AreEqual(4000, Kaiba.LifePoints);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            Assert.AreEqual(4000, Mai.LifePoints);
            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(0, Mai.DiscardPile.Count);
        }
    }
}
