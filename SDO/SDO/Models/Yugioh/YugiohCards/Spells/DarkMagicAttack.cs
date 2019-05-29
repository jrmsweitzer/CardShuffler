using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class DarkMagicAttack : NormalSpell
    {
        public DarkMagicAttack(YugiohGame game) : base(game)
        {
            Name = "Dark Magic Attack";
            SetCodes.Add("SS01-ENA11");
            CardCode = 02314238;
            Description = "If you control \"Dark Magician\": Destroy all Spells and Traps your opponent controls.";
        }

        
        
        
        
        
    }
}
