using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class WhiteElephantsGift : NormalSpell
    {
        public WhiteElephantsGift(YugiohGame game) : base(game)
        {
            Name = "White Elephant's Gift";
            SetCodes.Add("SBLS-EN040");
            CardCode = 18756904;
            Description = "Send 1 face-up non-Effect Monster you control to the GY; draw 2 cards.";
        }
    }
}
