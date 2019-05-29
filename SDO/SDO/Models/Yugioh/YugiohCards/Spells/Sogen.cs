using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class Sogen : FieldSpell
    {
        public Sogen(YugiohGame game) : base(game)
        {
            Name = "Sogen";
            SetCodes.Add("SS02-ENB14");
            CardCode = 86318356;
            Description = "All Warrior and Beast-Warrior monsters on the field gain 200 ATK/DEF.";
        }
        
    }
}
