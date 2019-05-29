using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class LegendarySword : EquipSpell
    {
        public LegendarySword(YugiohGame game) : base(game)
        {
            Name = "Legendary Sword";
            SetCodes.Add("SS02-ENB13");
            CardCode = 61854111;
            Description = "Equip only to a Warrior monster. It gains 300 ATK/DEF.";
        }
        
    }
}
