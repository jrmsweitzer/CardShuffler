using SDO.Models;
using SDO.Models.Yugioh;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SDO.Services;

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
        protected CardService cardSvc;

        [SetUp]
        public void SetUp()
        {
            Game = new YugiohGame();
            cardSvc = new CardService(Game);
            AllCardsInGame = cardSvc.GetAllCards();

            BlueEyesDeck = new Deck()
            {
                MainDeckCards = new List<Card>()
                {
                    cardSvc.GetCardByName("Blue-Eyes White Dragon"),
                    cardSvc.GetCardByName("Blue-Eyes White Dragon"),
                    cardSvc.GetCardByName("Blue-Eyes White Dragon"),
                    cardSvc.GetCardByName("Lord of D."),
                    cardSvc.GetCardByName("Lord of D."),
                    cardSvc.GetCardByName("Lord of D."),
                    cardSvc.GetCardByName("Tyrant Dragon"),
                    cardSvc.GetCardByName("Tyrant Dragon"),
                    cardSvc.GetCardByName("Tyrant Dragon"),
                    cardSvc.GetCardByName("Red-Eyes B. Dragon"),
                    cardSvc.GetCardByName("Red-Eyes B. Dragon"),
                    cardSvc.GetCardByName("The Flute of Summoning Dragon"),
                    cardSvc.GetCardByName("The Flute of Summoning Dragon"),
                    cardSvc.GetCardByName("The Flute of Summoning Dragon"),
                    cardSvc.GetCardByName("Windstorm of Etaqua"),
                    cardSvc.GetCardByName("Windstorm of Etaqua"),
                    cardSvc.GetCardByName("Windstorm of Etaqua"),
                    cardSvc.GetCardByName("Champion's Vigilance"),
                    cardSvc.GetCardByName("Champion's Vigilance"),
                    cardSvc.GetCardByName("Champion's Vigilance"),
                }
            };
            AmazonessDeck = new Deck()
            {
                MainDeckCards = new List<Card>()
                {
                    cardSvc.GetCardByName("Amazoness Swords Woman"),
                    cardSvc.GetCardByName("Amazoness Swords Woman"),
                    cardSvc.GetCardByName("Amazoness Swords Woman"),
                    cardSvc.GetCardByName("Amazoness Sage"),
                    cardSvc.GetCardByName("Amazoness Sage"),
                    cardSvc.GetCardByName("Amazoness Sage"),
                    cardSvc.GetCardByName("Amazoness Chain Master"),
                    cardSvc.GetCardByName("Amazoness Chain Master"),
                    cardSvc.GetCardByName("Amazoness Heirloom"),
                    cardSvc.GetCardByName("Amazoness Heirloom"),
                    cardSvc.GetCardByName("Amazoness Heirloom"),
                    cardSvc.GetCardByName("Amazoness Village"),
                    cardSvc.GetCardByName("Amazoness Village"),
                    cardSvc.GetCardByName("Amazoness Village"),
                    cardSvc.GetCardByName("Windstorm of Etaqua"),
                    cardSvc.GetCardByName("Windstorm of Etaqua"),
                    cardSvc.GetCardByName("Windstorm of Etaqua"),
                    cardSvc.GetCardByName("Kunai With Chain"),
                    cardSvc.GetCardByName("Kunai With Chain"),
                    cardSvc.GetCardByName("Kunai With Chain"),
                }
            };
            HarpieDeck = new Deck()
            {
                MainDeckCards = new List<Card>()
                {
                    cardSvc.GetCardByName("Harpie Lady 1"),
                    cardSvc.GetCardByName("Harpie Lady 1"),
                    cardSvc.GetCardByName("Harpie Lady 1"),
                    cardSvc.GetCardByName("Harpie Lady Sisters"),
                    cardSvc.GetCardByName("Harpie Lady Sisters"),
                    cardSvc.GetCardByName("Harpie Lady Sisters"),
                    cardSvc.GetCardByName("Birdface"),
                    cardSvc.GetCardByName("Birdface"),
                    cardSvc.GetCardByName("Birdface"),
                    cardSvc.GetCardByName("Elegant Egotist"),
                    cardSvc.GetCardByName("Elegant Egotist"),
                    cardSvc.GetCardByName("Elegant Egotist"),
                    cardSvc.GetCardByName("Harpie's Hunting Ground"),
                    cardSvc.GetCardByName("Harpie's Hunting Ground"),
                    cardSvc.GetCardByName("Harpie's Hunting Ground"),
                    cardSvc.GetCardByName("Windstorm of Etaqua"),
                    cardSvc.GetCardByName("Windstorm of Etaqua"),
                    cardSvc.GetCardByName("Windstorm of Etaqua"),
                    cardSvc.GetCardByName("Wild Tornado"),
                    cardSvc.GetCardByName("Wild Tornado"),
                }
            };
            ToonDeck = new Deck()
            {
                MainDeckCards = new List<Card>()
                {
                    cardSvc.GetCardByName("Toon Masked Sorcerer"),
                    cardSvc.GetCardByName("Toon Masked Sorcerer"),
                    cardSvc.GetCardByName("Toon Masked Sorcerer"),
                    cardSvc.GetCardByName("Toon Mermaid"),
                    cardSvc.GetCardByName("Toon Mermaid"),
                    cardSvc.GetCardByName("Toon Mermaid"),
                    cardSvc.GetCardByName("Toon Summoned Skull"),
                    cardSvc.GetCardByName("Toon Table of Contents"),
                    cardSvc.GetCardByName("Toon Table of Contents"),
                    cardSvc.GetCardByName("Toon Table of Contents"),
                    cardSvc.GetCardByName("Toon World"),
                    cardSvc.GetCardByName("Toon World"),
                    cardSvc.GetCardByName("Toon World"),
                    cardSvc.GetCardByName("Toon Rollback"),
                    cardSvc.GetCardByName("Windstorm of Etaqua"),
                    cardSvc.GetCardByName("Windstorm of Etaqua"),
                    cardSvc.GetCardByName("Windstorm of Etaqua"),
                    cardSvc.GetCardByName("Kunai With Chain"),
                    cardSvc.GetCardByName("Kunai With Chain"),
                    cardSvc.GetCardByName("Kunai With Chain"),
                }
            };
            TribalSynergyDeck = new Deck()
            {
                MainDeckCards = new List<Card>()
                {
                    cardSvc.GetCardByName("Amazoness Swords Woman"),
                    cardSvc.GetCardByName("Amazoness Swords Woman"),
                    cardSvc.GetCardByName("Amazoness Swords Woman"),
                    cardSvc.GetCardByName("Amazoness Sage"),
                    cardSvc.GetCardByName("Amazoness Sage"),
                    cardSvc.GetCardByName("Amazoness Chain Master"),
                    cardSvc.GetCardByName("Amazoness Chain Master"),
                    cardSvc.GetCardByName("Harpie Lady 1"),
                    cardSvc.GetCardByName("Harpie Lady 1"),
                    cardSvc.GetCardByName("Harpie Lady 1"),
                    cardSvc.GetCardByName("Amazoness Heirloom"),
                    cardSvc.GetCardByName("Amazoness Heirloom"),
                    cardSvc.GetCardByName("Amazoness Village"),
                    cardSvc.GetCardByName("Amazoness Village"),
                    cardSvc.GetCardByName("Windstorm of Etaqua"),
                    cardSvc.GetCardByName("Windstorm of Etaqua"),
                    cardSvc.GetCardByName("Windstorm of Etaqua"),
                    cardSvc.GetCardByName("Kunai With Chain"),
                    cardSvc.GetCardByName("Kunai With Chain"),
                    cardSvc.GetCardByName("Kunai With Chain"),
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
            return cardSvc.GetCardByName(name);
        }
    }
}
