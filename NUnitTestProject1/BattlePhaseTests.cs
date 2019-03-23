using CardShuffler.Models;
using CardShuffler.Models.Yugioh;
using CardShuffler.Models.Yugioh.Phases;
using CardShuffler.Models.Yugioh.YugiohCardTypes;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests.BattlePhaseTests
{
    public class BattlePhaseTests : TestBase
    {
        Monster BattleOx, BattleOx2, BattleOx3, TwinHeadedBehemoth, LusterDragon2, BlueEyesWhiteDragon;

        [SetUp]
        public void Setup()
        {
            var kaibaDeck = new Deck()
            {
                Cards = new List<Card>()
                {
                    (Monster)GetCardByName("Battle Ox"),
                    (Monster)GetCardByName("Twin-Headed Behemoth"),
                }
            };

            Kaiba.Deck = kaibaDeck;
            BattleOx = (Monster)Kaiba.Deck.AddCardToHand(Kaiba.Hand, "Battle Ox");
            TwinHeadedBehemoth = (Monster)Kaiba.Deck.AddCardToHand(Kaiba.Hand, "Twin-Headed Behemoth");
        }

        [Test]
        public void HigherAttackAgainstLowerAttackShouldWin()
        {
            Game.TurnPlayer = Kaiba;
            new MainPhase1(Game).NormalSummonWithoutTribute(BattleOx);
            Game.TurnPlayer = Mai;

            Mai.Deck = AmazonessDeck;
            var AmazonessChainMaster = (Monster)Mai.Deck.AddCardToHand(Mai.Hand, "Amazoness Chain Master");
            new MainPhase1(Game).NormalSummonWithoutTribute(AmazonessChainMaster);

            // before attack kaiba
            Assert.AreEqual(4000, Kaiba.LifePoints);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, BattleOx.Location);
            Assert.AreEqual(CardPosition.FaceUpAttack, BattleOx.Position);
            Assert.AreEqual(1700, BattleOx.ATK);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            // before attack mai
            Assert.AreEqual(4000, Mai.LifePoints);
            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, AmazonessChainMaster.Location);
            Assert.AreEqual(CardPosition.FaceUpAttack, AmazonessChainMaster.Position);
            Assert.AreEqual(1500, AmazonessChainMaster.ATK);
            Assert.AreEqual(0, Mai.DiscardPile.Count);

            Game.TurnPlayer = Kaiba;
            var battlePhase = new BattlePhase();
            battlePhase.Attack(Kaiba, BattleOx, Mai, AmazonessChainMaster);

            // after attack kaiba
            Assert.AreEqual(4000, Kaiba.LifePoints);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, BattleOx.Location);
            Assert.AreEqual(CardPosition.FaceUpAttack, BattleOx.Position);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            // after attack mai
            Assert.AreEqual(3800, Mai.LifePoints);
            Assert.AreEqual(0, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(1, Mai.DiscardPile.Count);
            Assert.AreEqual(CardLocation.Graveyard, AmazonessChainMaster.Location);
        }

        [Test]
        public void LowerAttackAgainstHigherAttackShouldLose()
        {
            Game.TurnPlayer = Kaiba;
            new MainPhase1(Game).NormalSummonWithoutTribute(BattleOx);
            Game.TurnPlayer = Mai;

            Mai.Deck = AmazonessDeck;
            var AmazonessChainMaster = (Monster)Mai.Deck.AddCardToHand(Mai.Hand, "Amazoness Chain Master");
            new MainPhase1(Game).NormalSummonWithoutTribute(AmazonessChainMaster);

            // before attack kaiba
            Assert.AreEqual(4000, Kaiba.LifePoints);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, BattleOx.Location);
            Assert.AreEqual(CardPosition.FaceUpAttack, BattleOx.Position);
            Assert.AreEqual(1700, BattleOx.ATK);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            // before attack mai
            Assert.AreEqual(4000, Mai.LifePoints);
            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, AmazonessChainMaster.Location);
            Assert.AreEqual(CardPosition.FaceUpAttack, AmazonessChainMaster.Position);
            Assert.AreEqual(1500, AmazonessChainMaster.ATK);
            Assert.AreEqual(0, Mai.DiscardPile.Count);

            var battlePhase = new BattlePhase();
            battlePhase.Attack(Mai, AmazonessChainMaster, Kaiba, BattleOx);

            // after attack kaiba
            Assert.AreEqual(4000, Kaiba.LifePoints);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, BattleOx.Location);
            Assert.AreEqual(CardPosition.FaceUpAttack, BattleOx.Position);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            // after attack mai
            Assert.AreEqual(3800, Mai.LifePoints);
            Assert.AreEqual(0, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(1, Mai.DiscardPile.Count);
            Assert.AreEqual(CardLocation.Graveyard, AmazonessChainMaster.Location);
        }

        [Test]
        public void EqualAttackAgainstEqualAttackShouldDestroyBoth()
        {
            Game.TurnPlayer = Kaiba;
            new MainPhase1(Game).NormalSummonWithoutTribute(TwinHeadedBehemoth);
            Game.TurnPlayer = Mai;

            Mai.Deck = AmazonessDeck;
            var AmazonessChainMaster = (Monster)Mai.Deck.AddCardToHand(Mai.Hand, "Amazoness Chain Master");
            new MainPhase1(Game).NormalSummonWithoutTribute(AmazonessChainMaster);

            // before attack kaiba
            Assert.AreEqual(4000, Kaiba.LifePoints);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, TwinHeadedBehemoth.Location);
            Assert.AreEqual(CardPosition.FaceUpAttack, TwinHeadedBehemoth.Position);
            Assert.AreEqual(1500, TwinHeadedBehemoth.ATK);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            // before attack mai
            Assert.AreEqual(4000, Mai.LifePoints);
            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, AmazonessChainMaster.Location);
            Assert.AreEqual(CardPosition.FaceUpAttack, AmazonessChainMaster.Position);
            Assert.AreEqual(1500, AmazonessChainMaster.ATK);
            Assert.AreEqual(0, Mai.DiscardPile.Count);

            var battlePhase = new BattlePhase();
            battlePhase.Attack(Mai, AmazonessChainMaster, Kaiba, TwinHeadedBehemoth);

            // after attack kaiba
            Assert.AreEqual(4000, Kaiba.LifePoints);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(1, Kaiba.DiscardPile.Count);
            Assert.AreEqual(CardLocation.Graveyard, TwinHeadedBehemoth.Location);
            // after attack mai
            Assert.AreEqual(4000, Mai.LifePoints);
            Assert.AreEqual(0, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(1, Mai.DiscardPile.Count);
            Assert.AreEqual(CardLocation.Graveyard, AmazonessChainMaster.Location);
        }

        [Test]
        public void LowerDefenseAgainstHigherDefenseShouldOnlyDealDamage()
        {
            Game.TurnPlayer = Kaiba;
            new MainPhase1(Game).NormalSummonWithoutTribute(TwinHeadedBehemoth);
            Game.TurnPlayer = Mai;

            Mai.Deck = AmazonessDeck;
            var AmazonessSwordsWoman = (Monster)Mai.Deck.AddCardToHand(Mai.Hand, "Amazoness Swords Woman");
            new MainPhase1(Game).NormalSetWithoutTribute(AmazonessSwordsWoman);            

            // before attack
            Assert.AreEqual(4000, Kaiba.LifePoints);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, TwinHeadedBehemoth.Location);
            Assert.AreEqual(CardPosition.FaceUpAttack, TwinHeadedBehemoth.Position);
            Assert.AreEqual(1500, TwinHeadedBehemoth.ATK);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            // before attack mai
            Assert.AreEqual(4000, Mai.LifePoints);
            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, AmazonessSwordsWoman.Location);
            Assert.AreEqual(CardPosition.FaceDownDefense, AmazonessSwordsWoman.Position);
            Assert.AreEqual(1600, AmazonessSwordsWoman.DEF);
            Assert.AreEqual(0, Mai.DiscardPile.Count);

            Game.TurnPlayer = Kaiba;
            var battlePhase = new BattlePhase();
            battlePhase.Attack(Kaiba, TwinHeadedBehemoth, Mai, AmazonessSwordsWoman);

            // after attack kaiba
            Assert.AreEqual(3900, Kaiba.LifePoints);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, TwinHeadedBehemoth.Location);
            Assert.AreEqual(CardPosition.FaceUpAttack, TwinHeadedBehemoth.Position);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            // after attack mai
            Assert.AreEqual(4000, Mai.LifePoints);
            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, AmazonessSwordsWoman.Location);
            Assert.AreEqual(CardPosition.FaceUpDefense, AmazonessSwordsWoman.Position);
            Assert.AreEqual(0, Mai.DiscardPile.Count);
        }

        [Test]
        public void HigherAttackAgainstLowerDefenseShouldWin()
        {
            Game.TurnPlayer = Kaiba;
            new MainPhase1(Game).NormalSetWithoutTribute(BattleOx);
            Game.TurnPlayer = Mai;

            Mai.Deck = AmazonessDeck;
            var AmazonessSwordsWoman = (Monster)Mai.Deck.AddCardToHand(Mai.Hand, "Amazoness Swords Woman");
            new MainPhase1(Game).NormalSummonWithoutTribute(AmazonessSwordsWoman);

            // before attack kaiba
            Assert.AreEqual(4000, Kaiba.LifePoints);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, BattleOx.Location);
            Assert.AreEqual(CardPosition.FaceDownDefense, BattleOx.Position);
            Assert.AreEqual(1000, BattleOx.DEF);
            // before attack mai
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            Assert.AreEqual(4000, Mai.LifePoints);
            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, AmazonessSwordsWoman.Location);
            Assert.AreEqual(CardPosition.FaceUpAttack, AmazonessSwordsWoman.Position);
            Assert.AreEqual(1500, AmazonessSwordsWoman.ATK);
            Assert.AreEqual(0, Mai.DiscardPile.Count);

            var battlePhase = new BattlePhase();
            battlePhase.Attack(Mai, AmazonessSwordsWoman, Kaiba, BattleOx);

            // after attack kaiba
            Assert.AreEqual(4000, Kaiba.LifePoints);
            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(1, Kaiba.DiscardPile.Count);
            Assert.AreEqual(CardLocation.Graveyard, BattleOx.Location);
            // after attack mai
            Assert.AreEqual(4000, Mai.LifePoints);
            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, AmazonessSwordsWoman.Location);
            Assert.AreEqual(CardPosition.FaceUpAttack, AmazonessSwordsWoman.Position);
            Assert.AreEqual(0, Mai.DiscardPile.Count);
        }

        [Test]
        public void EqualAttackAgainstEqualDefenseShouldTie()
        {
            Game.TurnPlayer = Kaiba;
            Kaiba.Deck = HarpieDeck;
            var kaibaBirdface = (Monster)Kaiba.Deck.AddCardToHand(Kaiba.Hand, "Birdface");
            new MainPhase1(Game).NormalSetWithoutTribute(kaibaBirdface);

            Game.TurnPlayer = Mai;
            Mai.Deck = HarpieDeck;
            var MaiBirdface = (Monster)Mai.Deck.AddCardToHand(Mai.Hand, "Birdface");
            new MainPhase1(Game).NormalSummonWithoutTribute(MaiBirdface);

            // before attack kaiba
            Assert.AreEqual(4000, Kaiba.LifePoints);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, kaibaBirdface.Location);
            Assert.AreEqual(CardPosition.FaceDownDefense, kaibaBirdface.Position);
            Assert.AreEqual(1600, kaibaBirdface.DEF);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            // before attack mai
            Assert.AreEqual(4000, Mai.LifePoints);
            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, MaiBirdface.Location);
            Assert.AreEqual(CardPosition.FaceUpAttack, MaiBirdface.Position);
            Assert.AreEqual(1600, MaiBirdface.DEF);
            Assert.AreEqual(0, Mai.DiscardPile.Count);

            var battlePhase = new BattlePhase();
            battlePhase.Attack(Mai, MaiBirdface, Kaiba, kaibaBirdface);

            // after attack kaiba
            Assert.AreEqual(4000, Kaiba.LifePoints);
            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, kaibaBirdface.Location);
            Assert.AreEqual(CardPosition.FaceUpDefense, kaibaBirdface.Position);
            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
            // after attack mai
            Assert.AreEqual(4000, Mai.LifePoints);
            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
            Assert.AreEqual(CardLocation.MonsterZone, MaiBirdface.Location);
            Assert.AreEqual(CardPosition.FaceUpAttack, MaiBirdface.Position);
            Assert.AreEqual(0, Mai.DiscardPile.Count);
        }
    }
}
