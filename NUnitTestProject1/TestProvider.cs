using CardShuffler.Models;
using CardShuffler.Models.Yugioh;
using CardShuffler.Models.Yugioh.YugiohCards;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CardSpecificTests
{
    public class TestProvider
    {
        private YugiohGame _game { get; set; }
        public YugiohGame Game
        {
            get
            {
                if (_game == null)
                    _game = new YugiohGame();
                return _game;
            }
            set
            {
                _game = value;
            }
        }
        public List<YugiohGameCard> GetAllCards()
        {
            var cards = MonsterList.GetMonsters(Game);
            cards.AddRange(SpellList.GetSpells(Game));
            cards.AddRange(TrapList.GetTraps(Game));
            return cards;
        }

        public YugiohGamePlayer GetBlueEyesPlayer()
        {
            var player = new YugiohGamePlayer()
            {
                Name = "Seto Kaiba",
                Deck = GetBlueEyesDeck(),
                LifePoints = 4000
            };
            player.Deck.Shuffle();
            return player;
        }

        public YugiohGamePlayer GetAmazonessPlayer()
        {
            var player = new YugiohGamePlayer()
            {
                Name = "Yami Yugi",
                Deck = GetAmazonessDeck(),
                LifePoints = 4000
            };
            return player;
        }

        public Card GetCardByName(string name)
        {
            return GetAllCards().FirstOrDefault(c => c.Name == name);
        }

        public Deck GetAmazonessDeck()
        {
            var deck = new Deck()
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
                    GetCardByName("Amazoness Village"),
                    GetCardByName("Amazoness Village"),
                    GetCardByName("Amazoness Village"),
                    GetCardByName("Amazoness Heirloom"),
                    GetCardByName("Amazoness Heirloom"),
                    GetCardByName("Amazoness Heirloom"),
                    GetCardByName("Windstorm of Etaqua"),
                    GetCardByName("Windstorm of Etaqua"),
                    GetCardByName("Windstorm of Etaqua"),
                    GetCardByName("Fiendish Chain"),
                    GetCardByName("Fiendish Chain"),
                    GetCardByName("Fiendish Chain"),
                }
            };
            return deck;
        }

        public Deck GetBlueEyesDeck()
        {
            var deck = new Deck()
            {
                Cards = new List<Card>()
                {
                    GetCardByName("Blue-Eyes White Dragon"),
                    GetCardByName("Blue-Eyes White Dragon"),
                    GetCardByName("Blue-Eyes White Dragon"),
                    GetCardByName("Lord of D."),
                    GetCardByName("Lord of D."),
                    GetCardByName("Lord of D."),
                    GetCardByName("Twin-Headed Behemoth"),
                    GetCardByName("Battle Ox"),
                    GetCardByName("Battle Ox"),
                    GetCardByName("Tyrant Dragon"),
                    GetCardByName("Tyrant Dragon"),
                    GetCardByName("The Flute of Summoning Dragon"),
                    GetCardByName("The Flute of Summoning Dragon"),
                    GetCardByName("The Flute of Summoning Dragon"),
                    GetCardByName("Stamping Destruction"),
                    GetCardByName("Stamping Destruction"),
                    GetCardByName("Stamping Destruction"),
                    GetCardByName("Burst Stream of Destruction"),
                    GetCardByName("Burst Stream of Destruction"),
                    GetCardByName("Burst Stream of Destruction"),
                }
            };
            return deck;
        }
    }
}
