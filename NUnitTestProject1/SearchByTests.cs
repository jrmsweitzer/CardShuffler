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
            Assert.IsTrue(monsters.Count() == 53);
        }
    }
}
