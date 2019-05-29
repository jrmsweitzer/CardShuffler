using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ShieldSword : NormalSpell
    {
        public ShieldSword(YugiohGame game) : base(game)
        {
            Name = "Shield & Sword";
            SetCodes.Add("SBLS-EN014");
            CardCode = 52097679;
            Description = "Switch the original ATK and DEF of all face-up monsters currently on the field, until the end of this turn.";
        }
        
    }
}
