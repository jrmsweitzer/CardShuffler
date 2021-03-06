﻿using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class GracefulDice : QuickplaySpell
    {
        public GracefulDice(YugiohGame game) : base(game)
        {
            Name = "Graceful Dice";
            SetCodes.Add("SS02-ENB16");
            CardCode = 74137509;
            Description = "Roll a six-sided die. All monsters you currently control gain ATK/DEF equal to the result x 100, until the end of this turn.";
        }

        
        
        
        
    }
}
