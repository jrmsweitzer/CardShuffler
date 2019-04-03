﻿using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class RiteofSpirit : NormalTrap
    {
        public RiteofSpirit(YugiohGame game) : base(game)
        {
            Name = "Rite of Spirit";
            SetCodes.Add("SS01-ENB16");
        }
    }
}
