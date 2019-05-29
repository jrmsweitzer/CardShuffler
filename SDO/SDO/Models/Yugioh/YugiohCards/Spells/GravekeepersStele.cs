using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class GravekeepersStele : NormalSpell
    {
        public GravekeepersStele(YugiohGame game) : base(game)
        {
            Name = "Gravekeeper's Stele";
            SetCodes.Add("SS01-ENB12");
            SetCodes.Add("STP1-EN018");
            CardCode = 99523325;
            Description = "Target 2 \"Gravekeeper's\" monsters in your GY; add those targets to your hand. This effect cannot be negated by the effect of \"Necrovalley\".";
        }
        
    }
}
