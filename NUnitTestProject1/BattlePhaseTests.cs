//using CardShuffler.Models;
//using CardShuffler.Models.Yugioh;
//using CardShuffler.Models.Yugioh.Phases;
//using CardShuffler.Models.Yugioh.YugiohCardTypes;
//using NUnit.Framework;
//using System.Collections.Generic;

//namespace Tests.BattlePhaseTests
//{
//    public class BattlePhaseTests : TestBase
//    {
//        Monster BattleOx, BattleOx2, BattleOx3, TwinHeadedBehemoth, LusterDragon2, BlueEyesWhiteDragon;

//        [SetUp]
//        public void Setup()
//        {
//            var kaibaDeck = new Deck()
//            {
//                Cards = new List<Card>()
//                {
//                    (Monster)GetCardByName("Battle Ox"),
//                    (Monster)GetCardByName("Battle Ox"),
//                    (Monster)GetCardByName("Battle Ox"),
//                    (Monster)GetCardByName("Twin-Headed Behemoth"),
//                    (Monster)GetCardByName("Luster Dragon #2"),
//                    (Monster)GetCardByName("Blue-Eyes White Dragon")
//                }
//            };

//            Kaiba.Deck = kaibaDeck;
//            BattleOx = (Monster)Kaiba.Deck.AddCardToHand(Kaiba.Hand, "Battle Ox");
//            BattleOx2 = (Monster)Kaiba.Deck.AddCardToHand(Kaiba.Hand, "Battle Ox");
//            BattleOx3 = (Monster)Kaiba.Deck.AddCardToHand(Kaiba.Hand, "Battle Ox");
//            TwinHeadedBehemoth = (Monster)Kaiba.Deck.AddCardToHand(Kaiba.Hand, "Twin-Headed Behemoth");
//            LusterDragon2 = (Monster)Kaiba.Deck.AddCardToHand(Kaiba.Hand, "Luster Dragon #2");
//            BlueEyesWhiteDragon = (Monster)Kaiba.Deck.AddCardToHand(Kaiba.Hand, "Blue-Eyes White Dragon");

//        [Test]
//        public void HigherAttackAgainstLowerAttackShouldWin()
//        {
//            Kaiba.Field.MonsterZones[0].Monster = BattleOx;
//            BattleOx.Location = CardLocation.MonsterZone;
//            BattleOx.Position = CardPosition.FaceUpAttack;

//            Mai.Field.MonsterZones[0].Monster = AmazonessChainMaster;
//            AmazonessChainMaster.Location = CardLocation.MonsterZone;
//            AmazonessChainMaster.Position = CardPosition.FaceUpAttack;

//            Assert.AreEqual(1700, BattleOx.ATK);
//            Assert.AreEqual(1500, AmazonessChainMaster.ATK);

//            // before attack
//            Assert.AreEqual(4000, Kaiba.LifePoints);
//            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
//            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
//            Assert.AreEqual(4000, Mai.LifePoints);
//            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
//            Assert.AreEqual(0, Mai.DiscardPile.Count);

//            var battlePhase = new BattlePhase();
//            battlePhase.Attack(Kaiba, BattleOx, Mai, AmazonessChainMaster);

//            Assert.AreEqual(4000, Kaiba.LifePoints);
//            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
//            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
//            Assert.AreEqual(3800, Mai.LifePoints);
//            Assert.AreEqual(0, Mai.Field.GetMonsters().Count);
//            Assert.AreEqual(1, Mai.DiscardPile.Count);
//        }

//        [Test]
//        public void LowerAttackAgainstHigherAttackShouldLose()
//        {
//            Kaiba.Field.MonsterZones[0].Monster = BattleOx;
//            BattleOx.Location = CardLocation.MonsterZone;
//            BattleOx.Position = CardPosition.FaceUpAttack;

//            Mai.Field.MonsterZones[0].Monster = AmazonessChainMaster;
//            AmazonessChainMaster.Location = CardLocation.MonsterZone;
//            AmazonessChainMaster.Position = CardPosition.FaceUpAttack;

//            Assert.AreEqual(1700, BattleOx.ATK);
//            Assert.AreEqual(1500, AmazonessChainMaster.ATK);

//            // before attack
//            Assert.AreEqual(4000, Kaiba.LifePoints);
//            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
//            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
//            Assert.AreEqual(4000, Mai.LifePoints);
//            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
//            Assert.AreEqual(0, Mai.DiscardPile.Count);

//            var battlePhase = new BattlePhase();
//            battlePhase.Attack(Mai, AmazonessChainMaster, Kaiba, BattleOx);

//            Assert.AreEqual(4000, Kaiba.LifePoints);
//            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
//            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
//            Assert.AreEqual(3800, Mai.LifePoints);
//            Assert.AreEqual(0, Mai.Field.GetMonsters().Count);
//            Assert.AreEqual(1, Mai.DiscardPile.Count);
//        }

//        [Test]
//        public void EqualAttackAgainstEqualAttackShouldDestroyBoth()
//        {
//            Kaiba.Field.MonsterZones[0].Monster = TwinHeadedBehemoth;
//            TwinHeadedBehemoth.Location = CardLocation.MonsterZone;
//            TwinHeadedBehemoth.Position = CardPosition.FaceUpAttack;

//            Mai.Field.MonsterZones[0].Monster = AmazonessChainMaster;
//            AmazonessChainMaster.Location = CardLocation.MonsterZone;
//            AmazonessChainMaster.Position = CardPosition.FaceUpAttack;

//            Assert.AreEqual(1500, TwinHeadedBehemoth.ATK);
//            Assert.AreEqual(1500, AmazonessChainMaster.ATK);

//            // before attack
//            Assert.AreEqual(4000, Kaiba.LifePoints);
//            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
//            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
//            Assert.AreEqual(4000, Mai.LifePoints);
//            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
//            Assert.AreEqual(0, Mai.DiscardPile.Count);

//            var battlePhase = new BattlePhase();
//            battlePhase.Attack(Mai, AmazonessChainMaster, Kaiba, TwinHeadedBehemoth);

//            Assert.AreEqual(4000, Kaiba.LifePoints);
//            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
//            Assert.AreEqual(1, Kaiba.DiscardPile.Count);
//            Assert.AreEqual(4000, Mai.LifePoints);
//            Assert.AreEqual(0, Mai.Field.GetMonsters().Count);
//            Assert.AreEqual(1, Mai.DiscardPile.Count);
//        }

//        [Test]
//        public void LowerDefenseAgainstHigherDefenseShouldOnlyDealDamage()
//        {
//            Kaiba.Field.MonsterZones[0].Monster = TwinHeadedBehemoth;
//            TwinHeadedBehemoth.Location = CardLocation.MonsterZone;
//            TwinHeadedBehemoth.Position = CardPosition.FaceUpAttack;

//            Mai.Field.MonsterZones[0].Monster = AmazonessSwordsWoman;
//            AmazonessSwordsWoman.Location = CardLocation.MonsterZone;
//            AmazonessSwordsWoman.Position = CardPosition.FaceUpDefense;

//            Assert.AreEqual(1500, TwinHeadedBehemoth.ATK);
//            Assert.AreEqual(1600, AmazonessSwordsWoman.DEF);

//            // before attack
//            Assert.AreEqual(4000, Kaiba.LifePoints);
//            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
//            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
//            Assert.AreEqual(4000, Mai.LifePoints);
//            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
//            Assert.AreEqual(0, Mai.DiscardPile.Count);

//            var battlePhase = new BattlePhase();
//            battlePhase.Attack(Kaiba, TwinHeadedBehemoth, Mai, AmazonessSwordsWoman);

//            Assert.AreEqual(3900, Kaiba.LifePoints);
//            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
//            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
//            Assert.AreEqual(4000, Mai.LifePoints);
//            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
//            Assert.AreEqual(0, Mai.DiscardPile.Count);
//        }

//        [Test]
//        public void HigherAttackAgianstLowerDefenseShouldWin()
//        {
//            Kaiba.Field.MonsterZones[0].Monster = BattleOx;
//            BattleOx.Location = CardLocation.MonsterZone;
//            BattleOx.Position = CardPosition.FaceUpDefense;

//            Mai.Field.MonsterZones[0].Monster = AmazonessSwordsWoman;
//            AmazonessSwordsWoman.Location = CardLocation.MonsterZone;
//            AmazonessSwordsWoman.Position = CardPosition.FaceUpAttack;

//            Assert.AreEqual(1000, BattleOx.DEF);
//            Assert.AreEqual(1500, AmazonessSwordsWoman.ATK);

//            // before attack
//            Assert.AreEqual(4000, Kaiba.LifePoints);
//            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
//            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
//            Assert.AreEqual(4000, Mai.LifePoints);
//            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
//            Assert.AreEqual(0, Mai.DiscardPile.Count);

//            var battlePhase = new BattlePhase();
//            battlePhase.Attack(Mai, AmazonessSwordsWoman, Kaiba, BattleOx);

//            Assert.AreEqual(4000, Kaiba.LifePoints);
//            Assert.AreEqual(0, Kaiba.Field.GetMonsters().Count);
//            Assert.AreEqual(1, Kaiba.DiscardPile.Count);
//            Assert.AreEqual(4000, Mai.LifePoints);
//            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
//            Assert.AreEqual(0, Mai.DiscardPile.Count);
//        }

//        [Test]
//        public void EqualAttackAgainstEqualDefenseShouldTie()
//        {
//            Kaiba.Field.MonsterZones[0].Monster = Birdface;
//            Birdface.Location = CardLocation.MonsterZone;
//            Birdface.Position = CardPosition.FaceUpDefense;

//            Mai.Field.MonsterZones[0].Monster = Birdface;
//            Birdface.Location = CardLocation.MonsterZone;
//            Birdface.Position = CardPosition.FaceUpAttack;

//            Assert.AreEqual(1600, Birdface.DEF);
//            Assert.AreEqual(1600, Birdface.ATK);

//            // before attack
//            Assert.AreEqual(4000, Kaiba.LifePoints);
//            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
//            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
//            Assert.AreEqual(4000, Mai.LifePoints);
//            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
//            Assert.AreEqual(0, Mai.DiscardPile.Count);

//            var battlePhase = new BattlePhase();
//            battlePhase.Attack(Mai, Birdface, Kaiba, Birdface);

//            Assert.AreEqual(4000, Kaiba.LifePoints);
//            Assert.AreEqual(1, Kaiba.Field.GetMonsters().Count);
//            Assert.AreEqual(0, Kaiba.DiscardPile.Count);
//            Assert.AreEqual(4000, Mai.LifePoints);
//            Assert.AreEqual(1, Mai.Field.GetMonsters().Count);
//            Assert.AreEqual(0, Mai.DiscardPile.Count);
//        }
//    }
//}
