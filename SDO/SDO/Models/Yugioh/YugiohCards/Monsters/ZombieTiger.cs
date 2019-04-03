﻿using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ZombieTiger : UnionMonster
    {
        public ZombieTiger(YugiohGame game) : base(game)
        {
            Name = "Zombie Tiger";
            SetCodes.Add("SBLS-EN033");
        }
    }
}
