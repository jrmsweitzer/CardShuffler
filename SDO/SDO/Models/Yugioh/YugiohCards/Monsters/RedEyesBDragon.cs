﻿using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class RedEyesBDragon : NormalMonster
    {
        public RedEyesBDragon(YugiohGame game) : base(game)
        {
            Name = "Red-Eyes B. Dragon";
            Attribute = MonsterAttribute.Dark;
            Level = 7;
            Type = MonsterType.Dragon;
            ATK = 2400;
            DEF = 2000;
            SetCodes.Add("SS02-ENB01");
            SetCodes.Add("STP1-EN007");
            CardCode = 74677422;
            Description = "A ferocious dragon with a deadly attack.";
        }
    }
}
