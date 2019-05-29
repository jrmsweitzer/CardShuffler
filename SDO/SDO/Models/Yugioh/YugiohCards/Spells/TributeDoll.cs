using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class TributeDoll : NormalSpell
    {
        public TributeDoll(YugiohGame game) : base(game)
        {
            Name = "Tribute Doll";
            SetCodes.Add("SS01-ENA13");
            CardCode = 02903036;
            Description = "Tribute 1 monster; Special Summon 1 Level 7 monster from your hand that can be Normal Summoned or Normal Set. It cannot attack this turn.";
        }
    }
}
