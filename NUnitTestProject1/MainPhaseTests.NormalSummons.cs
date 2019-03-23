using CardShuffler.Models;
using CardShuffler.Models.Yugioh;
using CardShuffler.Models.Yugioh.Phases;
using CardShuffler.Models.Yugioh.YugiohCardTypes;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Tests.MainPhaseTests.NormalSummon
{
    public class MainPhaseTests: TestBase
    {
        Monster BattleOx, BattleOx2, BattleOx3, TwinHeadedBehemoth, LusterDragon2, BlueEyesWhiteDragon;

        [SetUp]
        public void Setup()
        {
            var deck = new Deck()
            {
                Cards = new List<Card>()
                {
                    (Monster)GetCardByName("Battle Ox"),
                    (Monster)GetCardByName("Battle Ox"),
                    (Monster)GetCardByName("Battle Ox"),
                    (Monster)GetCardByName("Twin-Headed Behemoth"),
                    (Monster)GetCardByName("Luster Dragon #2"),
                    (Monster)GetCardByName("Blue-Eyes White Dragon")
                }
            };

            Kaiba.Deck = deck;
            BattleOx = (Monster)Kaiba.Deck.AddCardToHand(Kaiba.Hand, "Battle Ox");
            BattleOx2 = (Monster)Kaiba.Deck.AddCardToHand(Kaiba.Hand, "Battle Ox");
            BattleOx3 = (Monster)Kaiba.Deck.AddCardToHand(Kaiba.Hand, "Battle Ox");
            TwinHeadedBehemoth = (Monster)Kaiba.Deck.AddCardToHand(Kaiba.Hand, "Twin-Headed Behemoth");
            LusterDragon2 = (Monster)Kaiba.Deck.AddCardToHand(Kaiba.Hand, "Luster Dragon #2");
            BlueEyesWhiteDragon = (Monster)Kaiba.Deck.AddCardToHand(Kaiba.Hand, "Blue-Eyes White Dragon");
        }

        [Test]
        public void CanNormalSummonLevel4OrlowerWithoutTribute()
        {
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(4, BattleOx.Level);

            Assert.AreEqual(CardLocation.Hand, BattleOx.Location);
            var success = new MainPhase1(Game).NormalSummonWithoutTribute(BattleOx);

            Assert.True(success);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, BattleOx.Location);
            Assert.AreEqual(CardPosition.FaceUpAttack, BattleOx.Position);
        }
        [Test]
        public void CanNormalSetLevel4OrlowerWithoutTribute()
        {
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(4, BattleOx.Level);

            Assert.AreEqual(CardLocation.Hand, BattleOx.Location);
            var success = new MainPhase1(Game).NormalSetWithoutTribute(BattleOx);

            Assert.True(success);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, BattleOx.Location);
            Assert.AreEqual(CardPosition.FaceDownDefense, BattleOx.Position);
        }

        [Test]
        public void CannotNormalSummonLevel4OrLowerIfTooManyMonstersOnBoard()
        {
            new MainPhase1(Game).NormalSummonWithoutTribute(BattleOx);
            new MainPhase1(Game).NormalSummonWithoutTribute(BattleOx2);
            new MainPhase1(Game).NormalSummonWithoutTribute(BattleOx3);
            
            Assert.AreEqual(3, Kaiba.Field.GetMonsters().Count);

            Assert.AreEqual(CardLocation.Hand, TwinHeadedBehemoth.Location);
            var success = new MainPhase1(Game).NormalSummonWithoutTribute(TwinHeadedBehemoth);

            Assert.False(success);
            Assert.AreEqual(3, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.Hand, TwinHeadedBehemoth.Location);
        }

        [Test]
        public void CannotNormalSetLevel4OrLowerIfTooManyMonstersOnBoard()
        {
            new MainPhase1(Game).NormalSummonWithoutTribute(BattleOx);
            new MainPhase1(Game).NormalSummonWithoutTribute(BattleOx2);
            new MainPhase1(Game).NormalSummonWithoutTribute(BattleOx3);

            Assert.AreEqual(3, Kaiba.Field.GetMonsters().Count);

            Assert.AreEqual(CardLocation.Hand, TwinHeadedBehemoth.Location);
            var success = new MainPhase1(Game).NormalSetWithoutTribute(TwinHeadedBehemoth);

            Assert.False(success);
            Assert.AreEqual(3, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.Hand, TwinHeadedBehemoth.Location);
        }

        [Test]
        public void CannotNormalSummonLevel5OrHigherWithoutTribute()
        {
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(6, LusterDragon2.Level);

            Assert.AreEqual(CardLocation.Hand, LusterDragon2.Location);
            var success = new MainPhase1(Game).NormalSummonWithoutTribute(LusterDragon2);

            Assert.False(success);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.Hand, LusterDragon2.Location);
        }

        [Test]
        public void CannotNormalSetLevel5OrHigherWithoutTribute()
        {
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(6, LusterDragon2.Level);

            Assert.AreEqual(CardLocation.Hand, LusterDragon2.Location);
            var success = new MainPhase1(Game).NormalSetWithoutTribute(LusterDragon2);

            Assert.False(success);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.Hand, LusterDragon2.Location);
        }

        [Test]
        public void CannotTributeSummonLevel4OrLower()
        {
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(4, BattleOx.Level);

            Assert.AreEqual(CardLocation.Hand, BattleOx.Location);
            var success = new MainPhase1(Game).TributeSummon(BattleOx);

            Assert.False(success);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.Hand, BattleOx.Location);
        }

        [Test]
        public void CannotTributeSetLevel4OrLower()
        {
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(4, BattleOx.Level);

            Assert.AreEqual(CardLocation.Hand, BattleOx.Location);
            var success = new MainPhase1(Game).TributeSet(BattleOx);

            Assert.False(success);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.Hand, BattleOx.Location);
        }

        [Test]
        public void CannotTributeSummonLevel5OrHigherWithoutTributes()
        {
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(6, LusterDragon2.Level);

            Assert.AreEqual(CardLocation.Hand, LusterDragon2.Location);
            var success = new MainPhase1(Game).TributeSummon(LusterDragon2);

            Assert.False(success);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.Hand, LusterDragon2.Location);
        }

        [Test]
        public void CannotTributeSetLevel5OrHigherWithoutTributes()
        {
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(6, LusterDragon2.Level);

            Assert.AreEqual(CardLocation.Hand, LusterDragon2.Location);
            var success = new MainPhase1(Game).TributeSet(LusterDragon2);

            Assert.False(success);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.Hand, LusterDragon2.Location);
        }

        [Test]
        public void CanTributeSummonLevel5OrHigherWithOneTributeWithoutSpecifyingIfOnlyOneTributeIsOnBoard()
        {
            new MainPhase1(Game).NormalSummonWithoutTribute(BattleOx);

            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, BattleOx.Location);
            Assert.AreEqual(CardPosition.FaceUpAttack, BattleOx.Position);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            Assert.AreEqual(6, LusterDragon2.Level);
            Assert.AreEqual(CardLocation.Hand, LusterDragon2.Location);

            var success = new MainPhase1(Game).TributeSummon(LusterDragon2);

            Assert.True(success);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, LusterDragon2.Location);
            Assert.AreEqual(CardPosition.FaceUpAttack, LusterDragon2.Position);
            Assert.AreEqual(1, Kaiba.DiscardPile.Count);
            Assert.IsTrue(Kaiba.DiscardPile.Contains(BattleOx));
            Assert.AreEqual(CardLocation.Graveyard, BattleOx.Location);
        }

        [Test]
        public void CanTributeSetLevel5OrHigherWithOneTributeWithoutSpecifyingIfOnlyOneTributeIsOnBoard()
        {
            new MainPhase1(Game).NormalSummonWithoutTribute(BattleOx);
            
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, BattleOx.Location);
            Assert.AreEqual(CardPosition.FaceUpAttack, BattleOx.Position);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            Assert.AreEqual(6, LusterDragon2.Level);
            Assert.AreEqual(CardLocation.Hand, LusterDragon2.Location);

            var success = new MainPhase1(Game).TributeSet(LusterDragon2);

            Assert.True(success);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, LusterDragon2.Location);
            Assert.AreEqual(CardPosition.FaceDownDefense, LusterDragon2.Position);
            Assert.AreEqual(1, Kaiba.DiscardPile.Count);
            Assert.IsTrue(Kaiba.DiscardPile.Contains(BattleOx));
            Assert.AreEqual(CardLocation.Graveyard, BattleOx.Location);
        }

        [Test]
        public void CannotTributeSummonLevel5Or6WithoutSpecifyingTributeIfMoreThanOneMonsterOnBoard()
        {
            new MainPhase1(Game).NormalSummonWithoutTribute(BattleOx);
            new MainPhase1(Game).NormalSummonWithoutTribute(TwinHeadedBehemoth);
            
            Assert.AreEqual(2, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(6, LusterDragon2.Level);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);

            Assert.AreEqual(CardLocation.Hand, LusterDragon2.Location);
            Assert.AreEqual(CardLocation.MonsterZone, BattleOx.Location);
            Assert.AreEqual(CardLocation.MonsterZone, TwinHeadedBehemoth.Location);
            var success = new MainPhase1(Game).TributeSummon(LusterDragon2);

            Assert.False(success);
            Assert.AreEqual(2, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            Assert.AreEqual(CardLocation.Hand, LusterDragon2.Location);
            Assert.AreEqual(CardLocation.MonsterZone, BattleOx.Location);
            Assert.AreEqual(CardLocation.MonsterZone, TwinHeadedBehemoth.Location);
        }

        [Test]
        public void CannotTributeSetLevel5Or6WithoutSpecifyingTributeIfMoreThanOneMonsterOnBoard()
        {
            new MainPhase1(Game).NormalSummonWithoutTribute(BattleOx);
            new MainPhase1(Game).NormalSummonWithoutTribute(TwinHeadedBehemoth);
            
            Assert.AreEqual(2, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(6, LusterDragon2.Level);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);

            Assert.AreEqual(CardLocation.Hand, LusterDragon2.Location);
            var success = new MainPhase1(Game).TributeSet(LusterDragon2);

            Assert.False(success);
            Assert.AreEqual(2, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            Assert.AreEqual(CardLocation.Hand, LusterDragon2.Location);
        }

        [Test]
        public void CanTributeSummonLevel7OrHigherWithTwoTributeWithoutSpecifyingIfOnlTwoTributesAreOnBoard()
        {
            new MainPhase1(Game).NormalSummonWithoutTribute(BattleOx);
            new MainPhase1(Game).NormalSummonWithoutTribute(TwinHeadedBehemoth);
            
            Assert.AreEqual(2, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(8, BlueEyesWhiteDragon.Level);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);

            Assert.AreEqual(CardLocation.Hand, BlueEyesWhiteDragon.Location);
            var success = new MainPhase1(Game).TributeSummon(BlueEyesWhiteDragon);

            Assert.True(success);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, BlueEyesWhiteDragon.Location);
            Assert.AreEqual(CardPosition.FaceUpAttack, BlueEyesWhiteDragon.Position);
            Assert.AreEqual(2, Kaiba.DiscardPile.Count);
            Assert.IsTrue(Kaiba.DiscardPile.Contains(BattleOx));
            Assert.IsTrue(Kaiba.DiscardPile.Contains(TwinHeadedBehemoth));
            Assert.AreEqual(CardLocation.Graveyard, BattleOx.Location);
            Assert.AreEqual(CardLocation.Graveyard, TwinHeadedBehemoth.Location);
        }

        [Test]
        public void CanTributeSetLevel7OrHigherWithTwoTributeWithoutSpecifyingIfOnlTwoTributesAreOnBoard()
        {
            new MainPhase1(Game).NormalSummonWithoutTribute(BattleOx);
            new MainPhase1(Game).NormalSummonWithoutTribute(TwinHeadedBehemoth);
            
            Assert.AreEqual(2, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(8, BlueEyesWhiteDragon.Level);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);

            Assert.AreEqual(CardLocation.Hand, BlueEyesWhiteDragon.Location);
            var success = new MainPhase1(Game).TributeSet(BlueEyesWhiteDragon);

            Assert.True(success);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, BlueEyesWhiteDragon.Location);
            Assert.AreEqual(CardPosition.FaceDownDefense, BlueEyesWhiteDragon.Position);
            Assert.AreEqual(2, Kaiba.DiscardPile.Count);
            Assert.IsTrue(Kaiba.DiscardPile.Contains(BattleOx));
            Assert.IsTrue(Kaiba.DiscardPile.Contains(TwinHeadedBehemoth));
            Assert.AreEqual(CardLocation.Graveyard, BattleOx.Location);
            Assert.AreEqual(CardLocation.Graveyard, TwinHeadedBehemoth.Location);
        }

        [Test]
        public void CannotNormalSummonTwiceInSameMainPhase()
        {
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.Hand, BattleOx.Location);
            Assert.AreEqual(CardLocation.Hand, TwinHeadedBehemoth.Location);

            var phase = new MainPhase1(Game);
            var success = phase.NormalSummonWithoutTribute(BattleOx);

            // Fist summon should go through
            Assert.True(success);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, BattleOx.Location);
            Assert.AreEqual(CardLocation.Hand, TwinHeadedBehemoth.Location);

            success = phase.NormalSummonWithoutTribute(TwinHeadedBehemoth);
            Assert.False(success);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, BattleOx.Location);
            Assert.AreEqual(CardLocation.Hand, TwinHeadedBehemoth.Location);
        }

        [Test]
        public void CannotNormalSetTwiceInSameMainPhase()
        {
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.Hand, BattleOx.Location);
            Assert.AreEqual(CardLocation.Hand, TwinHeadedBehemoth.Location);

            var phase = new MainPhase1(Game);
            var success = phase.NormalSetWithoutTribute(BattleOx);

            // Fist summon should go through
            Assert.True(success);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, BattleOx.Location);
            Assert.AreEqual(CardLocation.Hand, TwinHeadedBehemoth.Location);

            success = phase.NormalSetWithoutTribute(TwinHeadedBehemoth);
            Assert.False(success);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, BattleOx.Location);
            Assert.AreEqual(CardLocation.Hand, TwinHeadedBehemoth.Location);
        }
    }
}
