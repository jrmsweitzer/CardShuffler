using CardShuffler.Models;
using CardShuffler.Models.Yugioh;
using CardShuffler.Models.Yugioh.YugiohCards;
using CardShuffler.Models.Yugioh.YugiohCardTypes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tests
{
    public class TestBase
    {
        protected YugiohGame Game;
        protected List<YugiohGameCard> AllCardsInGame;
        protected Deck BlueEyesDeck;
        protected Deck AmazonessDeck;
        protected Deck HarpieDeck;
        protected Deck TribalSynergyDeck;
        protected Deck ToonDeck;
        protected YugiohGamePlayer Kaiba;
        protected YugiohGamePlayer Mai;
        protected YugiohGamePlayer Pegasus;

        [SetUp]
        public void SetUp()
        {
            Game = new YugiohGame();
            AllCardsInGame = BuildCardsFromFiles(Game);

            BlueEyesDeck = new Deck()
            {
                Cards = new List<Card>()
                {
                    GetCardByName("Blue-Eyes White Dragon"),
                    GetCardByName("Blue-Eyes White Dragon"),
                    GetCardByName("Blue-Eyes White Dragon"),
                    GetCardByName("Lord of D."),
                    GetCardByName("Lord of D."),
                    GetCardByName("Lord of D."),
                    GetCardByName("Tyrant Dragon"),
                    GetCardByName("Tyrant Dragon"),
                    GetCardByName("Tyrant Dragon"),
                    GetCardByName("Red-Eyes B. Dragon"),
                    GetCardByName("Red-Eyes B. Dragon"),
                    GetCardByName("The Flute of Summoning Dragon"),
                    GetCardByName("The Flute of Summoning Dragon"),
                    GetCardByName("The Flute of Summoning Dragon"),
                    GetCardByName("Windstorm of Etaqua"),
                    GetCardByName("Windstorm of Etaqua"),
                    GetCardByName("Windstorm of Etaqua"),
                    GetCardByName("Champion's Vigilance"),
                    GetCardByName("Champion's Vigilance"),
                    GetCardByName("Champion's Vigilance"),
                }
            };
            AmazonessDeck = new Deck()
            {
                Cards = new List<Card>()
                {
                    GetCardByName("Amazoness Swords Woman"),
                    GetCardByName("Amazoness Swords Woman"),
                    GetCardByName("Amazoness Swords Woman"),
                    GetCardByName("Amazoness Sage"),
                    GetCardByName("Amazoness Sage"),
                    GetCardByName("Amazoness Sage"),
                    GetCardByName("Amazoness Chain Master"),
                    GetCardByName("Amazoness Chain Master"),
                    GetCardByName("Amazoness Heirloom"),
                    GetCardByName("Amazoness Heirloom"),
                    GetCardByName("Amazoness Heirloom"),
                    GetCardByName("Amazoness Village"),
                    GetCardByName("Amazoness Village"),
                    GetCardByName("Amazoness Village"),
                    GetCardByName("Windstorm of Etaqua"),
                    GetCardByName("Windstorm of Etaqua"),
                    GetCardByName("Windstorm of Etaqua"),
                    GetCardByName("Kunai With Chain"),
                    GetCardByName("Kunai With Chain"),
                    GetCardByName("Kunai With Chain"),
                }
            };
            HarpieDeck = new Deck()
            {
                Cards = new List<Card>()
                {
                    GetCardByName("Harpie Lady 1"),
                    GetCardByName("Harpie Lady 1"),
                    GetCardByName("Harpie Lady 1"),
                    GetCardByName("Harpie Lady Sisters"),
                    GetCardByName("Harpie Lady Sisters"),
                    GetCardByName("Harpie Lady Sisters"),
                    GetCardByName("Birdface"),
                    GetCardByName("Birdface"),
                    GetCardByName("Birdface"),
                    GetCardByName("Elegant Egotist"),
                    GetCardByName("Elegant Egotist"),
                    GetCardByName("Elegant Egotist"),
                    GetCardByName("Harpie's Hunting Ground"),
                    GetCardByName("Harpie's Hunting Ground"),
                    GetCardByName("Harpie's Hunting Ground"),
                    GetCardByName("Windstorm of Etaqua"),
                    GetCardByName("Windstorm of Etaqua"),
                    GetCardByName("Windstorm of Etaqua"),
                    GetCardByName("Wild Tornado"),
                    GetCardByName("Wild Tornado"),
                }
            };
            ToonDeck = new Deck()
            {
                Cards = new List<Card>()
                {
                    GetCardByName("Toon Masked Sorcerer"),
                    GetCardByName("Toon Masked Sorcerer"),
                    GetCardByName("Toon Masked Sorcerer"),
                    GetCardByName("Toon Mermaid"),
                    GetCardByName("Toon Mermaid"),
                    GetCardByName("Toon Mermaid"),
                    GetCardByName("Toon Summoned Skull"),
                    GetCardByName("Toon Table of Contents"),
                    GetCardByName("Toon Table of Contents"),
                    GetCardByName("Toon Table of Contents"),
                    GetCardByName("Toon World"),
                    GetCardByName("Toon World"),
                    GetCardByName("Toon World"),
                    GetCardByName("Toon Rollback"),
                    GetCardByName("Windstorm of Etaqua"),
                    GetCardByName("Windstorm of Etaqua"),
                    GetCardByName("Windstorm of Etaqua"),
                    GetCardByName("Kunai With Chain"),
                    GetCardByName("Kunai With Chain"),
                    GetCardByName("Kunai With Chain"),
                }
            };
            TribalSynergyDeck = new Deck()
            {
                Cards = new List<Card>()
                {
                    GetCardByName("Amazoness Swords Woman"),
                    GetCardByName("Amazoness Swords Woman"),
                    GetCardByName("Amazoness Swords Woman"),
                    GetCardByName("Amazoness Sage"),
                    GetCardByName("Amazoness Sage"),
                    GetCardByName("Amazoness Chain Master"),
                    GetCardByName("Amazoness Chain Master"),
                    GetCardByName("Harpie Lady 1"),
                    GetCardByName("Harpie Lady 1"),
                    GetCardByName("Harpie Lady 1"),
                    GetCardByName("Amazoness Heirloom"),
                    GetCardByName("Amazoness Heirloom"),
                    GetCardByName("Amazoness Village"),
                    GetCardByName("Amazoness Village"),
                    GetCardByName("Windstorm of Etaqua"),
                    GetCardByName("Windstorm of Etaqua"),
                    GetCardByName("Windstorm of Etaqua"),
                    GetCardByName("Kunai With Chain"),
                    GetCardByName("Kunai With Chain"),
                    GetCardByName("Kunai With Chain"),
                }
            };
            Kaiba = new YugiohGamePlayer()
            {
                Deck = BlueEyesDeck,
                Name = "Kaiba",
                LifePoints = 4000
            };
            Mai = new YugiohGamePlayer()
            {
                Deck = AmazonessDeck,
                Name = "Mai",
                LifePoints = 4000
            };
            Pegasus = new YugiohGamePlayer()
            {
                Deck = ToonDeck,
                Name = "Pegasus",
                LifePoints = 4000
            };
            Game.P1 = Kaiba;
            Game.P2 = Mai;
            Game.TurnPlayer = Kaiba;
            Kaiba.SetDeck(BlueEyesDeck);
            Mai.SetDeck(AmazonessDeck);
        }
        
        public YugiohGameCard GetCardByName(string name)
        {
            var trimmedName = name.Replace(" ", "").Replace("-", "").Replace(".", "").Replace("#","").Replace("'","").Replace(",", "");
            var fqt = $"CardShuffler.Models.Yugioh.YugiohCards.{trimmedName}";
            var type = Type.GetType(fqt);
            if (type != null)
                return (YugiohGameCard)Activator.CreateInstance(type);

            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                type = asm.GetType(fqt);
                if (type != null)
                    return (YugiohGameCard)Activator.CreateInstance(type, Game);
            }
            return null;
            //var card = AllCardsInGame.FirstOrDefault(c => c.Name == name);

            //if (card is EffectMonster effectMonster)
            //    return effectMonster.Clone();
            //if (card is NormalMonster normalMonster)
            //    return normalMonster.Clone();

            //return card;
        }

        public List<YugiohGameCard> BuildCardsFromFiles(YugiohGame game)
        {
            var pathIndex = Directory.GetCurrentDirectory().IndexOf("NUnitTestProject");
            var path = Path.Combine(Directory.GetCurrentDirectory().Substring(0, pathIndex), "CardShuffler", "Models", "Yugioh", "YugiohCards");


            var list = new List<YugiohGameCard>();
            
            DirectoryInfo d = new DirectoryInfo(path);

            var subDirectories = d.GetDirectories();
            foreach (var subDir in subDirectories)
            {
                FileInfo[] Files = subDir.GetFiles("*.cs");
                foreach (var file in Files)
                {
                    var name = file.Name.Replace(".cs", "");
                    list.Add(GetCardByName(name));
                }
            }            

            return list;
        }

        public YugiohGameCard GetCardByCardCode(int cardCode)
        {
            return AllCardsInGame.FirstOrDefault(c => c.CardCode == cardCode);
        }
    }
}
