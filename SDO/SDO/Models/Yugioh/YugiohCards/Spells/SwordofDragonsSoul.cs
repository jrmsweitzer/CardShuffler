using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class SwordofDragonsSoul : EquipSpell
    {
        public SwordofDragonsSoul(YugiohGame game) : base(game)
        {
            Name = "Sword of Dragon's Soul";
            SetCodes.Add("SBLS-EN015");
            CardCode = 61405855;
            Description = "Equip only to a Warrior monster. It gains 700 ATK. After damage calculation, if the equipped monster battled a Dragon monster: Destroy that monster at the end of that Battle Phase.";
        }
    }
}
