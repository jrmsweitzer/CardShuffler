using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class FusionGate : FieldSpell
    {
        public FusionGate(YugiohGame game) : base(game)
        {
            Name = "Fusion Gate";
            SetCodes.Add("SS02-ENV02");
            CardCode = 33550694;
            Description = "While this card is on the field: The turn player can Fusion Summon 1 Fusion Monster from their Extra Deck, by banishing Fusion Materials listed on it from their hand or field.";
        }
    }
}
