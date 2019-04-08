using SDO.Models.Yugioh;
using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SDO.Services
{
    public class CardService
    {
        private YugiohGame _game;
        private List<YugiohGameCard> Cards { get; set; }


        public CardService(YugiohGame game)
        {
            _game = game;
        }
        public CardService()
        {
            _game = null;
        }

        public YugiohGameCard GetCardByName(string name)
        {
            var trimmedName = name.Replace(" ", "").Replace("-", "").Replace(".", "").Replace("#", "").Replace("'", "").Replace(",", "").Replace("&", "");

            var type = AppDomain.CurrentDomain.GetAssemblies().ToList().FirstOrDefault(asm => asm.FullName.Contains("SDO")).GetTypes().FirstOrDefault(t => t.FullName.EndsWith($".{trimmedName}"));
            if (type != null)
                return (YugiohGameCard)Activator.CreateInstance(type, _game);
            else
                throw new Exception("Cannot find type with name " + name);
        }

        public List<YugiohGameCard> GetAllCards()
        {
            if (Cards == null)
            {
                var list = new List<YugiohGameCard>();

                var allAssemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();

                var allAssemblyNames = allAssemblies.Select(asm => asm.FullName).ToList();


                var yugiohCardAssembly = allAssemblies.FirstOrDefault(asm => asm.FullName.StartsWith("SDO,"));
                var types = yugiohCardAssembly.GetTypes().Where(t => t.FullName.Contains(".YugiohCards."));

                foreach (var type in types)
                {
                    try
                    {
                        list.Add((YugiohGameCard)Activator.CreateInstance(type, _game));
                    }
                    catch { }
                }

                Cards = list;
            }

            return Cards;            
        }

        public string BuildDecklistFromDecks(List<YugiohGameCard> mainDeck, List<YugiohGameCard> fusionDeck, List<YugiohGameCard> sideDeck)
        {
            var builder = new StringBuilder();
            builder.Append("__Skill__;");
            if (mainDeck.Any(c => c is Skill))
            {
                builder.Append(mainDeck.FirstOrDefault(c => c is Skill).Name);
            }
            builder.Append("__Main__;");
            foreach (var card in mainDeck)
                builder.Append(card.Name + ";");
            builder.Append("__Fusion__;");
            foreach (var card in fusionDeck)
                builder.Append(card.Name + ";");
            builder.Append("__Side__;");
            foreach (var card in sideDeck)
                builder.Append(card.Name + ";");

            return builder.ToString();
        }

        public List<YugiohGameCard> BuildMainDeckFromDecklist(string decklist)
        {
            var list = new List<YugiohGameCard>();

            var mainDeckStartingIndex = decklist.IndexOf("__Main__" + 9);
            var fusionDeckStartingIndex = decklist.IndexOf("__Fusion__" + 11);

            if (mainDeckStartingIndex != 10)
            {
                var skillName = decklist.Substring(10, mainDeckStartingIndex - 10);
                list.Add(GetCardByName(skillName));
            }

            if (fusionDeckStartingIndex != mainDeckStartingIndex + 9)
            {
                var mainDeckCardNames = decklist.Substring(mainDeckStartingIndex, fusionDeckStartingIndex - mainDeckStartingIndex).Split(';');

                foreach (var card in mainDeckCardNames)
                {
                    list.Add(GetCardByName(card));
                }
            }

            return list;
        }

        public List<YugiohGameCard> BuildFusionDeckFromDecklist(string decklist)
        {
            var list = new List<YugiohGameCard>();

            var fusionDeckStartingIndex = decklist.IndexOf("__Fusion__;" + 11);
            var sideDeckStartingIndex = decklist.IndexOf("__Side__;" + 9);


            if (sideDeckStartingIndex != fusionDeckStartingIndex + 9)
            {
                var fusionDeckCardNames = decklist.Substring(fusionDeckStartingIndex, sideDeckStartingIndex - fusionDeckStartingIndex).Split(';');

                foreach (var card in fusionDeckCardNames)
                {
                    list.Add(GetCardByName(card));
                }
            }

            return list;
        }

        public List<YugiohGameCard> BuildSideDeckFromDecklist(string decklist)
        {
            var list = new List<YugiohGameCard>();

            var sideDeckStartingIndex = decklist.IndexOf("__Side__;" + 9);

            if (decklist.Length > sideDeckStartingIndex + 9)
            {
                var sideDeckCardNames = decklist.Substring(sideDeckStartingIndex).Split(';');

                foreach (var card in sideDeckCardNames)
                {
                    list.Add(GetCardByName(card));
                }
            }

            return list;
        }
    }
}
