using CardShuffler.Models.Yugioh.Phases;
using CardShuffler.Models.Yugioh.YugiohCardTypes;
using NUnit.Framework;
using System.Linq;

namespace Tests.MainPhaseTests.NormalSummon
{
    public class MainPhaseTests: TestBase
    {

        [SetUp]
        public void Setup()
        {
            BattleOx = (Monster)GetCardByName("Battle Ox");
            TwinHeadedBehemoth = (Monster)GetCardByName("Twin-Headed Behemoth");
            LusterDragon2 = (Monster)GetCardByName("Luster Dragon #2");
            BlueEyesWhiteDragon = (Monster)GetCardByName("Blue-Eyes White Dragon");
        }

        [Test]
        public void CanNormalSummonLevel4OrlowerWithoutTribute()
        {
            Kaiba.Hand.Cards.Add(BattleOx);

            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(4, BattleOx.Level);

            var success = new MainPhase1(Game).NormalSummonWithoutTribute(BattleOx);

            Assert.True(success);
            Assert.AreEqual(0, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            var zone = Kaiba.Field.MonsterZones.First(z => z.Monster == BattleOx);
            Assert.IsTrue(zone.AttackPosition);
            Assert.IsTrue(zone.FaceUp);
        }
        [Test]
        public void CanNormalSetLevel4OrlowerWithoutTribute()
        {
            Kaiba.Hand.Cards.Add(BattleOx);

            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(4, BattleOx.Level);

            var success = new MainPhase1(Game).NormalSetWithoutTribute(BattleOx);

            Assert.True(success);
            Assert.AreEqual(0, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            var zone = Kaiba.Field.MonsterZones.First(z => z.Monster == BattleOx);
            Assert.IsFalse(zone.AttackPosition);
            Assert.IsFalse(zone.FaceUp);
        }

        [Test]
        public void CannotNormalSummonLevel4OrLowerIfTooManyMonstersOnBoard()
        {
            Kaiba.Field.MonsterZones[0].Monster = BlueEyesWhiteDragon;
            Kaiba.Field.MonsterZones[0].AttackPosition = true;
            Kaiba.Field.MonsterZones[0].FaceUp = true;
            Kaiba.Field.MonsterZones[1].Monster = LusterDragon2;
            Kaiba.Field.MonsterZones[1].AttackPosition = true;
            Kaiba.Field.MonsterZones[1].FaceUp = true;
            Kaiba.Field.MonsterZones[2].Monster = BattleOx;
            Kaiba.Field.MonsterZones[2].AttackPosition = true;
            Kaiba.Field.MonsterZones[2].FaceUp = true;
            Kaiba.Hand.Cards.Add(TwinHeadedBehemoth);

            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(3, Kaiba.Field.GetMonsters().Count);

            var success = new MainPhase1(Game).NormalSummonWithoutTribute(TwinHeadedBehemoth);

            Assert.False(success);
            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(3, Kaiba.Field.GetMonsters().Count);
        }

        [Test]
        public void CannotNormalSetLevel4OrLowerIfTooManyMonstersOnBoard()
        {
            Kaiba.Field.MonsterZones[0].Monster = BlueEyesWhiteDragon;
            Kaiba.Field.MonsterZones[0].AttackPosition = true;
            Kaiba.Field.MonsterZones[0].FaceUp = true;
            Kaiba.Field.MonsterZones[1].Monster = LusterDragon2;
            Kaiba.Field.MonsterZones[1].AttackPosition = true;
            Kaiba.Field.MonsterZones[1].FaceUp = true;
            Kaiba.Field.MonsterZones[2].Monster = BattleOx;
            Kaiba.Field.MonsterZones[2].AttackPosition = true;
            Kaiba.Field.MonsterZones[2].FaceUp = true;
            Kaiba.Hand.Cards.Add(TwinHeadedBehemoth);

            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(3, Kaiba.Field.GetMonsters().Count);

            var success = new MainPhase1(Game).NormalSetWithoutTribute(TwinHeadedBehemoth);

            Assert.False(success);
            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(3, Kaiba.Field.GetMonsters().Count);
        }

        [Test]
        public void CannotNormalSummonLevel5OrHigherWithoutTribute()
        {
            Kaiba.Hand.Cards.Add(LusterDragon2);

            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(6, LusterDragon2.Level);

            var success = new MainPhase1(Game).NormalSummonWithoutTribute(LusterDragon2);

            Assert.False(success);
            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
        }

        [Test]
        public void CannotNormalSetLevel5OrHigherWithoutTribute()
        {
            Kaiba.Hand.Cards.Add(LusterDragon2);

            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(6, LusterDragon2.Level);

            var success = new MainPhase1(Game).NormalSetWithoutTribute(LusterDragon2);

            Assert.False(success);
            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
        }

        [Test]
        public void CannotTributeSummonLevel4OrLower()
        {
            Kaiba.Hand.Cards.Add(BattleOx);

            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(4, BattleOx.Level);

            var success = new MainPhase1(Game).TributeSummon(BattleOx);

            Assert.False(success);
            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
        }

        [Test]
        public void CannotTributeSetLevel4OrLower()
        {
            Kaiba.Hand.Cards.Add(BattleOx);

            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(4, BattleOx.Level);

            var success = new MainPhase1(Game).TributeSet(BattleOx);

            Assert.False(success);
            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
        }

        [Test]
        public void CannotTributeSummonLevel5OrHigherWithoutTributes()
        {
            Kaiba.Hand.Cards.Add(LusterDragon2);

            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(6, LusterDragon2.Level);

            var success = new MainPhase1(Game).TributeSummon(LusterDragon2);

            Assert.False(success);
            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
        }

        [Test]
        public void CannotTributeSetLevel5OrHigherWithoutTributes()
        {
            Kaiba.Hand.Cards.Add(LusterDragon2);

            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(6, LusterDragon2.Level);

            var success = new MainPhase1(Game).TributeSet(LusterDragon2);

            Assert.False(success);
            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
        }

        [Test]
        public void CanTributeSummonLevel5OrHigherWithOneTributeWithoutSpecifyingIfOnlyOneTributeIsOnBoard()
        {
            Kaiba.Field.MonsterZones[0].Monster = BattleOx;
            Kaiba.Field.MonsterZones[0].AttackPosition = true;
            Kaiba.Field.MonsterZones[0].FaceUp = true;
            Kaiba.Hand.Cards.Add(LusterDragon2);

            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(6, LusterDragon2.Level);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);

            var success = new MainPhase1(Game).TributeSummon(LusterDragon2);

            Assert.True(success);
            Assert.AreEqual(0, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            var zone = Kaiba.Field.MonsterZones.First(z => z.Monster == LusterDragon2);
            Assert.IsTrue(zone.Monster.Name == "Luster Dragon #2");
            Assert.IsTrue(zone.AttackPosition);
            Assert.IsTrue(zone.FaceUp);
            Assert.AreEqual(1, Kaiba.DiscardPile.Count);
            Assert.IsTrue(Kaiba.DiscardPile.Contains(BattleOx));
        }

        [Test]
        public void CanTributeSetLevel5OrHigherWithOneTributeWithoutSpecifyingIfOnlyOneTributeIsOnBoard()
        {
            Kaiba.Field.MonsterZones[0].Monster = BattleOx;
            Kaiba.Field.MonsterZones[0].AttackPosition = true;
            Kaiba.Field.MonsterZones[0].FaceUp = true;
            Kaiba.Hand.Cards.Add(LusterDragon2);

            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(6, LusterDragon2.Level);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);

            var success = new MainPhase1(Game).TributeSet(LusterDragon2);

            Assert.True(success);
            Assert.AreEqual(0, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            var zone = Kaiba.Field.MonsterZones.First(z => z.Monster == LusterDragon2);
            Assert.IsTrue(zone.Monster.Name == "Luster Dragon #2");
            Assert.IsFalse(zone.AttackPosition);
            Assert.IsFalse(zone.FaceUp);
            Assert.AreEqual(1, Kaiba.DiscardPile.Count);
            Assert.IsTrue(Kaiba.DiscardPile.Contains(BattleOx));
        }

        [Test]
        public void CannotTributeSummonLevel5Or6WithoutSpecifyingTributeIfMoreThanOneMonsterOnBoard()
        {
            Kaiba.Field.MonsterZones[0].Monster = BattleOx;
            Kaiba.Field.MonsterZones[0].AttackPosition = true;
            Kaiba.Field.MonsterZones[0].FaceUp = true;
            Kaiba.Field.MonsterZones[1].Monster = TwinHeadedBehemoth;
            Kaiba.Field.MonsterZones[1].AttackPosition = true;
            Kaiba.Field.MonsterZones[1].FaceUp = true;
            Kaiba.Hand.Cards.Add(LusterDragon2);

            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(2, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(6, LusterDragon2.Level);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);

            var success = new MainPhase1(Game).TributeSummon(LusterDragon2);

            Assert.False(success);
            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(2, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
        }

        [Test]
        public void CannotTributeSetLevel5Or6WithoutSpecifyingTributeIfMoreThanOneMonsterOnBoard()
        {
            Kaiba.Field.MonsterZones[0].Monster = BattleOx;
            Kaiba.Field.MonsterZones[0].AttackPosition = true;
            Kaiba.Field.MonsterZones[0].FaceUp = true;
            Kaiba.Field.MonsterZones[1].Monster = TwinHeadedBehemoth;
            Kaiba.Field.MonsterZones[1].AttackPosition = true;
            Kaiba.Field.MonsterZones[1].FaceUp = true;
            Kaiba.Hand.Cards.Add(LusterDragon2);

            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(2, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(6, LusterDragon2.Level);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);

            var success = new MainPhase1(Game).TributeSet(LusterDragon2);

            Assert.False(success);
            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(2, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
        }

        [Test]
        public void CanTributeSummonLevel7OrHigherWithTwoTributeWithoutSpecifyingIfOnlTwoTributesAreOnBoard()
        {
            Kaiba.Field.MonsterZones[0].Monster = BattleOx;
            Kaiba.Field.MonsterZones[0].AttackPosition = true;
            Kaiba.Field.MonsterZones[0].FaceUp = true;
            Kaiba.Field.MonsterZones[1].Monster = TwinHeadedBehemoth;
            Kaiba.Field.MonsterZones[1].AttackPosition = true;
            Kaiba.Field.MonsterZones[1].FaceUp = true;
            Kaiba.Hand.Cards.Add(BlueEyesWhiteDragon);

            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(2, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(8, BlueEyesWhiteDragon.Level);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);

            var success = new MainPhase1(Game).TributeSummon(BlueEyesWhiteDragon);

            Assert.True(success);
            Assert.AreEqual(0, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            var zone = Kaiba.Field.MonsterZones.First(z => z.Monster == BlueEyesWhiteDragon);
            Assert.IsTrue(zone.Monster.Name == "Blue-Eyes White Dragon");
            Assert.IsTrue(zone.AttackPosition);
            Assert.IsTrue(zone.FaceUp);
            Assert.AreEqual(2, Kaiba.DiscardPile.Count);
            Assert.IsTrue(Kaiba.DiscardPile.Contains(BattleOx));
            Assert.IsTrue(Kaiba.DiscardPile.Contains(TwinHeadedBehemoth));
        }

        [Test]
        public void CanTributeSetLevel7OrHigherWithTwoTributeWithoutSpecifyingIfOnlTwoTributesAreOnBoard()
        {
            Kaiba.Field.MonsterZones[0].Monster = BattleOx;
            Kaiba.Field.MonsterZones[0].AttackPosition = true;
            Kaiba.Field.MonsterZones[0].FaceUp = true;
            Kaiba.Field.MonsterZones[1].Monster = TwinHeadedBehemoth;
            Kaiba.Field.MonsterZones[1].AttackPosition = true;
            Kaiba.Field.MonsterZones[1].FaceUp = true;
            Kaiba.Hand.Cards.Add(BlueEyesWhiteDragon);

            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(2, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(8, BlueEyesWhiteDragon.Level);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);

            var success = new MainPhase1(Game).TributeSet(BlueEyesWhiteDragon);

            Assert.True(success);
            Assert.AreEqual(0, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            var zone = Kaiba.Field.MonsterZones.First(z => z.Monster == BlueEyesWhiteDragon);
            Assert.IsTrue(zone.Monster.Name == "Blue-Eyes White Dragon");
            Assert.IsFalse(zone.AttackPosition);
            Assert.IsFalse(zone.FaceUp);
            Assert.AreEqual(2, Kaiba.DiscardPile.Count);
            Assert.IsTrue(Kaiba.DiscardPile.Contains(BattleOx));
            Assert.IsTrue(Kaiba.DiscardPile.Contains(TwinHeadedBehemoth));
        }

        [Test]
        public void CannotNormalSummonTwiceInSameMainPhase()
        {
            Kaiba.Hand.Cards.Add(BattleOx);
            Kaiba.Hand.Cards.Add(TwinHeadedBehemoth);

            Assert.AreEqual(2, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);

            var phase = new MainPhase1(Game);
            var success = phase.NormalSummonWithoutTribute(BattleOx);

            // Fist summon should go through
            Assert.True(success);
            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);

            success = phase.NormalSummonWithoutTribute(TwinHeadedBehemoth);
            Assert.False(success);
            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
        }

        [Test]
        public void CannotNormalSetTwiceInSameMainPhase()
        {
            Kaiba.Hand.Cards.Add(BattleOx);
            Kaiba.Hand.Cards.Add(TwinHeadedBehemoth);

            Assert.AreEqual(2, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);

            var phase = new MainPhase1(Game);
            var success = phase.NormalSetWithoutTribute(BattleOx);

            // Fist summon should go through
            Assert.True(success);
            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);

            success = phase.NormalSetWithoutTribute(TwinHeadedBehemoth);
            Assert.False(success);
            Assert.AreEqual(1, Kaiba.Hand.Cards.Count);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
        }
    }
}
