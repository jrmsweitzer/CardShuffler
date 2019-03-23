using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class DarkMagician : NormalMonster
    {
        public DarkMagician(YugiohGame game) : base(game)
        {
            Name = "Dark Magician";
            Attribute = MonsterAttribute.Dark;
            Level = 7;
            Type = MonsterType.Spellcaster;
            ATK = 2500;
            DEF = 2100;
        }
    }
}
