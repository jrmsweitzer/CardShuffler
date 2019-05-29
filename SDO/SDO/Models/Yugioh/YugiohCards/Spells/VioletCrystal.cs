using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class VioletCrystal : EquipSpell
    {
        public VioletCrystal(YugiohGame game) : base(game)
        {
            Name = "Violet Crystal";
            SetCodes.Add("SBLS-EN035");
            CardCode = 15052462;
            Description = "(This card is not treated as a \"Crystal\" card.)\n" +
"Equip only to a Zombie monster. It gains 300 ATK / DEF.";
        }
    }
}
