using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class DarkRabbit : NormalMonster
    {
        public DarkRabbit(YugiohGame game) : base(game)
        {
            Name = "Dark Rabbit";
            Attribute = MonsterAttribute.Dark;
            Level = 4;
            Type = MonsterType.Beast;
            ATK = 1100;
            DEF = 1500;
            CardCode = 99261403;
            SetCodes.Add("SS01-ENC04");
        }
    }
}
