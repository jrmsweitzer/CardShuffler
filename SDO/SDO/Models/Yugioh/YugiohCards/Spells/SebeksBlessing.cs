using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class SebeksBlessing : QuickplaySpell
    {
        public SebeksBlessing(YugiohGame game) : base(game)
        {
            Name = "Sebek's Blessing";
            SetCodes.Add("SS01-ENB14");
            CardCode = 22537443;
            Description = "Activate only when a monster you control has attacked your opponent directly. Gain Life Points equal to the Battle Damage that the monster inflicted to your opponent.";
        }
    }
}
