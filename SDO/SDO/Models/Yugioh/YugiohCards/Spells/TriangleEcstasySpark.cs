﻿using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class TriangleEcstasySpark : NormalSpell
    {
        public TriangleEcstasySpark(YugiohGame game) : base(game)
        {
            Name = "Triangle Ecstacy Spark";
            SetCodes.Add("SS02-ENC11");
            CardCode = 12181376;
            Description = "Until the end of this turn, the ATK of all \"Harpie Lady Sisters\" currently on the field becomes 2700, your opponent cannot activate any Trap Cards, also negate all your opponent's Trap effects on the field.";
        }
    }
}
