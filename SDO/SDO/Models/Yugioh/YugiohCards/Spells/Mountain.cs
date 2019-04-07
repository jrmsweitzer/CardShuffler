using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class Mountain : FieldSpell
    {
        public Mountain(YugiohGame game) : base(game)
        {
            Name = "Mountain";
            SetCodes.Add("SS02-ENA14");
            CardCode = 50913601;
            Description = "All Dragon, Winged Beast, and Thunder monsters on the field gain 200 ATK/DEF.";
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
        public override void WhenRemoved() => throw new NotImplementedException();
    }
}
