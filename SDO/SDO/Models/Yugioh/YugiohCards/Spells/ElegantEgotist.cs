using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ElegantEgotist : NormalSpell
    {
        public ElegantEgotist(YugiohGame game) : base(game)
        {
            Name = "Elegant Egotist";
            SetCodes.Add("SS02-ENC10");
            SetCodes.Add("STP1-EN015");
            CardCode = 90219263;
            Description = "If \"Harpie Lady\" is on the field: Special Summon 1 \"Harpie Lady\" or \"Harpie Lady Sisters\" from your hand or Deck.";
        }
    }
}
