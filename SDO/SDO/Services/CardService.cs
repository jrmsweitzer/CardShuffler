using SDO.Models.Yugioh;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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


            //var fqt = $"SDO.Models.Yugioh.YugiohCards.{trimmedName}";
            //var type = Type.GetType(fqt);
            //if (type != null)
            //    return (YugiohGameCard)Activator.CreateInstance(type, _game);

            //foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            //{
            //    type = asm.GetType(fqt);
            //    if (type != null)
            //        return (YugiohGameCard)Activator.CreateInstance(type, _game);
            //}
            //return null;
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
    }
}
