using CardShuffler.Models.Yugioh.YugiohCardTypes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    public class SearchByTests: TestBase
    {
        [Test]
        public void SearchByCardCode()
        {
            var code = 46986414;
            var card = (Monster)GetCardByCardCode(code);
            Assert.AreEqual("Dark Magician", card.Name);
        }

        [Test]
        public void SearchByName()
        {
            var name = "Toon";
            var cards = AllCardsInGame.Where(c => c.Name.Contains(name));

            Assert.IsTrue(cards.Any(c => c.Name == "Toon Masked Sorcerer"));
            Assert.IsTrue(cards.Any(c => c.Name == "Toon Mermaid"));
            Assert.IsTrue(cards.Any(c => c.Name == "Toon Summoned Skull"));
            Assert.IsTrue(cards.Any(c => c.Name == "Toon World"));
        }

        [Test]
        public void SearchBySet()
        {
            var set = "SS01-ENA";
            var cards = AllCardsInGame.Where(c => c.SetCodes.Any(sc => sc.StartsWith(set)));

            Assert.IsTrue(cards.Any(c => c.Name == "Dark Magician"));
        }

        [Test]
        public void SearchByCardType()
        {
            var monsters = AllCardsInGame.Where(c => c is Monster);
            Assert.IsNotNull(monsters);
            Assert.IsTrue(monsters.Count() >= 55);
        }

        [Test]
        public void SS01ENA_21()
        {
            var yugiCards = AllCardsInGame.Where(c => c.SetCodes.Any(sc => sc.Contains("SS01-ENA"))).ToList();
            Assert.AreEqual(21, yugiCards.Count);
        }

        [Test]
        public void SS01ENB_20()
        {
            var ishizuCards = AllCardsInGame.Where(c => c.SetCodes.Any(sc => sc.Contains("SS01-ENB"))).ToList();
            Assert.AreEqual(20, ishizuCards.Count);
        }

        [Test]
        public void SS01ENC_20()
        {
            var pegasusCards = AllCardsInGame.Where(c => c.SetCodes.Any(sc => sc.Contains("SS01-ENC"))).ToList();
            Assert.AreEqual(20, pegasusCards.Count);
        }

        [Test]
        public void SS01ENV_3()
        {
            var variantCardsInFirstDeck = AllCardsInGame.Where(c => c.SetCodes.Any(sc => sc.Contains("SS01-ENV"))).ToList();
            Assert.AreEqual(3, variantCardsInFirstDeck.Count);
        }

        [Test]
        public void SS02ENA_20()
        {
            var kaibaCards = AllCardsInGame.Where(c => c.SetCodes.Any(sc => sc.Contains("SS02-ENA"))).ToList();
            Assert.AreEqual(20, kaibaCards.Count);
        }

        [Test]
        public void SS02ENB_25()
        {
            var joeyCards = AllCardsInGame.Where(c => c.SetCodes.Any(sc => sc.Contains("SS02-ENB"))).ToList();
            Assert.AreEqual(25, joeyCards.Count);
        }

        [Test]
        public void SS02ENC_21()
        {
            var maiCards = AllCardsInGame.Where(c => c.SetCodes.Any(sc => sc.Contains("SS02-ENC"))).ToList();
            Assert.AreEqual(21, maiCards.Count);
        }

        [Test]
        public void SS02ENV_3()
        {
            var variantCardsInSecondDeck = AllCardsInGame.Where(c => c.SetCodes.Any(sc => sc.Contains("SS02-ENV"))).ToList();
            Assert.AreEqual(3, variantCardsInSecondDeck.Count);
        }

        [Test]
        public void SBLS_50()
        {
            var arenaOflostSoulsCards = AllCardsInGame.Where(c => c.SetCodes.Any(sc => sc.Contains("SBLS-EN"))).ToList();
            Assert.AreEqual(50, arenaOflostSoulsCards.Count);
        }

        [Test]
        public void AllCardsHaveSetCodes()
        {
            var cardsWithoutSetCodes = AllCardsInGame.Where(c => c.SetCodes == null);
            Assert.AreEqual(0, cardsWithoutSetCodes.Count());
        }

        [Test]
        public void MonsterCount_84()
        {
            var monsters = AllCardsInGame.Where(c => c is Monster);
            Assert.AreEqual(84, monsters.Count());
        }

        [Test]
        public void RitualMonsterCount_1()
        {
            var monsters = AllCardsInGame.Where(c => c is RitualMonster);
            Assert.AreEqual(1, monsters.Count());
        }

        [Test]
        public void FusionMonsterCount_8()
        {
            var monsters = AllCardsInGame.Where(c => c is FusionMonster);
            Assert.AreEqual(8, monsters.Count());
        }

        [Test]
        public void SpellCount_49()
        {
            var spells = AllCardsInGame.Where(c => c is Spell);
            Assert.AreEqual(49, spells.Count());
        }

        [Test]
        public void TrapCount_25()
        {
            var traps = AllCardsInGame.Where(c => c is Trap);
            Assert.AreEqual(25, traps.Count());
        }

        [Test]
        public void SkillCount_23()
        {
            var skills = AllCardsInGame.Where(c => c is Skill);
            Assert.AreEqual(23, skills.Count());
        }
    }
}
