﻿using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class RyuKishinPowered : NormalMonster
    {
        public RyuKishinPowered(YugiohGame game) : base(game)
        {
            Name = "Ryu-Kishin Powered";
            Attribute = MonsterAttribute.Dark;
            Level = 4;
            Type = MonsterType.Fiend;
            ATK = 1600;
            DEF = 1200;
            SetCodes.Add("SS02-ENA03");
            CardCode = 24611934;
            Description = "A gargoyle enhanced by the powers of darkness. Very sharp talons make it a worthy opponent.";
        }
    }
}
