using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class WickedBreakingFlambergeBaou : EquipSpell
    {
        public WickedBreakingFlambergeBaou(YugiohGame game) : base(game)
        {
            Name = "Wicked-Breaking Flamberge - Baou";
            SetCodes.Add("SBLS-EN041");
            CardCode = 68427465;
            Description = "Send 1 card from your hand to the GY, then target 1 monster on the field; equip this card to that target. It gains 500 ATK. Negate the effects of opponent's monsters destroyed by battle with the equipped monster.";
        }
    }
}
