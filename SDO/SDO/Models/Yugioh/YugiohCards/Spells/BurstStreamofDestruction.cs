using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class BurstStreamofDestruction : NormalSpell
    {
        public BurstStreamofDestruction(YugiohGame game) : base(game)
        {
            Name = "Burst Stream of Destruction";
            SetCodes.Add("SS02-ENA13");
            CardCode = 17655904;
            Description = "If you control \"Blue - Eyes White Dragon\": Destroy all monsters your opponent controls. \"Blue - Eyes White Dragon\" you control cannot attack the turn you activate this card.";
        }

        
        
        
        
        
    }
}
