using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class StampingDestruction : NormalSpell
    {
        public StampingDestruction(YugiohGame game) : base(game)
        {
            Name = "Stamping Destruction";
            SetCodes.Add("SS02-ENA11");
            CardCode = 81385346;
            Description = "If you control a Dragon monster: Target 1 Spell/Trap on the field; destroy that target, and if you do, inflict 500 damage to its controller.";
        }
        
    }
}
