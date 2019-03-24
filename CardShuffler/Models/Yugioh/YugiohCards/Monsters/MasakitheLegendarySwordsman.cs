using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class MasakitheLegendarySwordsman : NormalMonster
    {
        public MasakitheLegendarySwordsman(YugiohGame game) : base(game)
        {
            Name = "Masaki the Legendary Swordsman";
            Attribute = MonsterAttribute.Earth;
            Level = 4;
            Type = MonsterType.Warrior;
            ATK = 1100;
            DEF = 1100;
            CardCode = 44287299;
            SetCodes.Add("SS02-ENB04");
        }
    }
}
