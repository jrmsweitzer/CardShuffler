using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class RogueDoll : NormalMonster
    {
        public RogueDoll(YugiohGame game) : base(game)
        {
            Name = "Rogue Doll";
            Attribute = MonsterAttribute.Light;
            Level = 4;
            Type = MonsterType.Spellcaster;
            ATK = 1600;
            DEF = 1000;
        }
    }
}
