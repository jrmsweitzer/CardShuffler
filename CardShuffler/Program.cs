using CardShuffler.Extensions;
using CardShuffler.Models;
using CardShuffler.Models.Yugioh;
using CardShuffler.Models.Yugioh.YugiohCards;
using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CardShuffler
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new YugiohGamePlayer();
            var opponent = new YugiohGamePlayer();
            var game = new YugiohGame();
            var allCards = MonsterList.GetMonsters(game);
            game.P1 = player;
            game.P2 = opponent;
            allCards.AddRange(SpellList.GetSpells(game));
            allCards.AddRange(TrapList.GetTraps(game));

            var deck = new List<Card>()
            {
                allCards.FirstOrDefault(c => c.Name == "Blue-Eyes White Dragon"),
                allCards.FirstOrDefault(c => c.Name == "Blue-Eyes White Dragon"),
                allCards.FirstOrDefault(c => c.Name == "Blue-Eyes White Dragon"),
                allCards.FirstOrDefault(c => c.Name == "Lord of D."),
                allCards.FirstOrDefault(c => c.Name == "Lord of D."),
                allCards.FirstOrDefault(c => c.Name == "Lord of D."),
                allCards.FirstOrDefault(c => c.Name == "Battle Ox"),
                allCards.FirstOrDefault(c => c.Name == "Battle Ox"),
                allCards.FirstOrDefault(c => c.Name == "Battle Ox"),
                allCards.FirstOrDefault(c => c.Name == "Tyrant Dragon"),
                allCards.FirstOrDefault(c => c.Name == "Tyrant Dragon"),
                allCards.FirstOrDefault(c => c.Name == "The Flute of Summoning Dragon"),
                allCards.FirstOrDefault(c => c.Name == "The Flute of Summoning Dragon"),
                allCards.FirstOrDefault(c => c.Name == "The Flute of Summoning Dragon"),
                allCards.FirstOrDefault(c => c.Name == "Stamping Destruction"),
                allCards.FirstOrDefault(c => c.Name == "Stamping Destruction"),
                allCards.FirstOrDefault(c => c.Name == "Stamping Destruction"),
                allCards.FirstOrDefault(c => c.Name == "Burst Stream of Destruction"),
                allCards.FirstOrDefault(c => c.Name == "Burst Stream of Destruction"),
                allCards.FirstOrDefault(c => c.Name == "Burst Stream of Destruction"),
            };

            //var kaiba = new List<string>()
            //{
            //    "Blue-Eyes White Dragon",
            //    "Blue-Eyes White Dragon",
            //    "Blue-Eyes White Dragon",
            //    "Lord of D.",
            //    "Lord of D.",
            //    "Lord of D.",
            //    "The Flute of Summoning Dragon",
            //    "The Flute of Summoning Dragon",
            //    "The Flute of Summoning Dragon",
            //    "Twin-Headed Behemoth",
            //    "Twin-Headed Behemoth",
            //    "Twin-Headed Behemoth",
            //    "Dragon's Rebirth",
            //    "Dragon's Rebirth",
            //    "Riryoku",
            //    "Blue Dragon Summoner",
            //    "Champion's Vigilance",
            //    "Champion's Vigilance",
            //    "Baby Dragon",
            //    "Baby Dragon",
            //};

            //var mai = new List<string>()
            //{
            //    "Harpie Lady 1",
            //    "Harpie Lady 1",
            //    "Harpie Lady 1",
            //    "Harpie Lady Sisters",
            //    "Elegant Egotist",
            //    "Elegant Egotist",
            //    "Amazoness Chain Master",
            //    "Amazoness Chain Master",
            //    "Amazoness Village",
            //    "Amazoness Village",
            //    "Amazoness Swords Woman",
            //    "Amazoness Swords Woman",
            //    "Amazoness Swords Woman",
            //    "Amazoness Sage",
            //    "Amazoness Sage",
            //    "Amazoness Heirloom",
            //    "Amazoness Heirloom",
            //    "Cyber Shield",
            //    "Windstorm of Etaqua",
            //    "Windstorm of Etaqua",
            //};

            //var joey = new List<string>()
            //{
            //    "Gearfried The Iron Knight",
            //    "Gearfried The Iron Knight",
            //    "Gearfried The Iron Knight",
            //    "Battle Ox",
            //    "Battle Ox",
            //    "Battle Ox",
            //    "Copycat",
            //    "Copycat",
            //    "Sogen",
            //    "Sogen",
            //    "Graceful Dice",
            //    "Graceful Dice",
            //    "Graceful Dice",
            //    "Skull Dice",
            //    "Skull Dice",
            //    "Skull Dice",
            //    "Wild Tornado",
            //    "Wild Tornado",
            //    "Wild Tornado",
            //    "Kunai With Chain"
            //};

            var shuffledDeck = deck.Shuffle();

            var hand = new List<Card>();

            Console.WriteLine("Total deck size: " + shuffledDeck.Count);
            Console.WriteLine();
            Console.WriteLine("Drawing 4 cards");
            Console.WriteLine("You drew:");

            for (int i = 0; i <4; i++)
            {
                DrawCard(shuffledDeck, hand);
            }

            foreach (var card in hand)
            {
                Console.WriteLine(card.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("The rest of the deck:");

            for (int i = 0; i < shuffledDeck.Count; i++)
                Console.WriteLine(shuffledDeck[i].ToString());


            Console.WriteLine();

            var normalMonstersLv4orLower = hand.Where(c => c.GetType() == typeof(NormalMonster) && ((NormalMonster)c).Level <= 4).ToList();
            var effectMonstersLv4OrLowerThatCanBeNormalSummoned = hand.Where(c => c.GetType() == typeof(EffectMonster) &&
                    ((EffectMonster)c).CanBeNormalSummoned &&
                    ((EffectMonster)c).Level <= 4);

            var properMonsters = normalMonstersLv4orLower;
            properMonsters.AddRange(effectMonstersLv4OrLowerThatCanBeNormalSummoned);

            if (properMonsters.Count() > 0)
            {
                Console.WriteLine("Monsters in hand that can be normal summoned: ");
                foreach (var monster in properMonsters)
                    Console.WriteLine(monster.ToString());
            }
            

            Console.ReadKey();
        }

        public static void DrawCard(List<Card> deck, List<Card> hand)
        {
            if (deck.Count == 0)
                throw new Exception("Cannot draw from an empty deck!");
            
            hand.Add(deck[0]);
            deck.RemoveAt(0);
        }
    }
}
