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

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
        public override void WhenRemoved() => throw new NotImplementedException();
    }
}
