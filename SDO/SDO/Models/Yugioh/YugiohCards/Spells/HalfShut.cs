using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class HalfShut : QuickplaySpell
    {
        public HalfShut(YugiohGame game) : base(game)
        {
            Name = "Half Shut";
            SetCodes.Add("SBLS-EN043");
            CardCode = 73048641;
            Description = "Target 1 face-up monster on the field; it cannot be destroyed by battle this turn, also its ATK is halved until the end of this turn.";
        }
        
    }
}
