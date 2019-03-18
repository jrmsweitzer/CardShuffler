using CardShuffler.Models;
using CardShuffler.Models.Yugioh;
using CardShuffler.Models.Yugioh.YugiohCards;
using CardShuffler.Models.Yugioh.YugiohCardTypes;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class TestBase
    {
        protected YugiohGame Game;
        private List<Card> AllCardsInGame;
        protected Deck BlueEyesDeck;
        protected Deck AmazonessDeck;
        protected Deck HarpieDeck;
        protected Deck ToonDeck;
        protected YugiohGamePlayer Kaiba;
        protected YugiohGamePlayer Mai;
        protected YugiohGamePlayer Pegasus;

        protected Monster AmazonessChainMaster;
        protected Monster AmazonessSwordsWoman;
        protected Monster BattleOx;
        protected Monster TwinHeadedBehemoth;
        protected Monster LusterDragon2;
        protected Monster BlueEyesWhiteDragon;
        protected Monster HarpieLady1;
        protected Monster Birdface;

        [SetUp]
        public void SetUp()
        {
            Game = new YugiohGame();
            var monsters = MonsterList.GetMonsters(Game);
            var traps = Traps.GetTraps(Game);
            var spells = SpellList.GetSpells(Game);
            AllCardsInGame = new List<Card>();
            AllCardsInGame.AddRange(monsters);
            AllCardsInGame.AddRange(spells);
            AllCardsInGame.AddRange(traps);

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
            AmazonessChainMaster = (Monster)GetCardByName("Amazoness Chain Master");
            AmazonessSwordsWoman = (Monster)GetCardByName("Amazoness Swords Woman");
            BattleOx = (Monster)GetCardByName("Battle Ox");
            Birdface = (Monster)GetCardByName("Birdface");
            BlueEyesWhiteDragon = (Monster)GetCardByName("Blue-Eyes White Dragon");
            HarpieLady1 = (Monster)GetCardByName("Harpie Lady 1");
            LusterDragon2 = (Monster)GetCardByName("Luster Dragon #2");
            TwinHeadedBehemoth = (Monster)GetCardByName("Twin-Headed Behemoth");
        }
        
        public Card GetCardByName(string name)
        {
            var card = AllCardsInGame.FirstOrDefault(c => c.Name == name);

            if (card is EffectMonster effectMonster)
                return effectMonster.Clone();
            if (card is NormalMonster normalMonster)
                return normalMonster.Clone();

            return card;
        }
    }
}
