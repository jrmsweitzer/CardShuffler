using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class Sogen : FieldSpell
    {
        public Sogen(YugiohGame game) : base(game)
        {
            Name = "Sogen";
            SetCodes.Add("SS02-ENB14");
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
        public override void WhenRemoved() => throw new NotImplementedException();
    }
}
