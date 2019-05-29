using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ThousandKnives : NormalSpell
    {
        public ThousandKnives(YugiohGame game) : base(game)
        {
            Name = "Thousand Knives";
            SetCodes.Add("SS01-ENA09");
            CardCode = 63391643;
            Description = "If you control \"Dark Magician\": Target 1 monster your opponent controls; destroy that target.";
        }
    }
}
