using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ShardofGreed : ContinuousSpell
    {
        public ShardofGreed(YugiohGame game) : base(game)
        {
            Name = "Shard of Greed";
            SetCodes.Add("SS01-ENV01");
            CardCode = 33904024;
            Description = "Each time you draw a card(s) for your normal draw in your Draw Phase, place 1 Greed Counter on this card. You can send this card with 2 or more Greed Counters to the GY; draw 2 cards.";
        }
        
    }
}
