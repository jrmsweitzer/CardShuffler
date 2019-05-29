using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class DeSpell : NormalSpell
    {
        public DeSpell(YugiohGame game) : base(game)
        {
            Name = "De-Spell";
            SetCodes.Add("SBLS-EN037");
            CardCode = 19159413;
            Description = "Target 1 face-up Spell, or 1 Set Spell/Trap, on the field; destroy that target if it is a Spell. (If the target is Set, reveal it.)";
        }
    }
}