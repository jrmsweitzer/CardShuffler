using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class BlackIllusionRitual : RitualSpell
    {
        public BlackIllusionRitual(YugiohGame game) : base(game)
        {
            Name = "Black Illusion Ritual";
            SetCodes.Add("SS01-ENC09");
            SetCodes.Add("STP1-EN011");
            CardCode = 41426869;
            Description = "This card is used to Ritual Summon \"Relinquished\". You must also Tribute a monster from your hand or field whose Level is 1 or more.";
        }
    }
}
