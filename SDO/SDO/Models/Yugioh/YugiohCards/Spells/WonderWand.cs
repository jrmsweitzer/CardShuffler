using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class WonderWand : EquipSpell
    {
        public WonderWand(YugiohGame game) : base(game)
        {
            Name = "Wonder Wand";
            SetCodes.Add("SS01-ENA14");
            SetCodes.Add("STP1-EN003");
            CardCode = 67775894;
            Description = "Equip only to a Spellcaster-Type monster. It gains 500 ATK. If you control the equipped monster and this card: You can send both to the GY; draw 2 cards.";
        }
    }
}
