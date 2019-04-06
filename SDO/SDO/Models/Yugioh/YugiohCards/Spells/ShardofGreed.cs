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
            Description = "Each time you draw a card(s) for your normal draw in your Draw Phase, place 1 Greed Counter on this card. You can send this card with 2 or more Greed Counters to the Graveyard; draw 2 cards.";
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
