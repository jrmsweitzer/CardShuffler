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
            CardCode = 86318356;
            Description = "All Warrior and Beast-Warrior monsters on the field gain 200 ATK/DEF.";
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
        public override void WhenRemoved() => throw new NotImplementedException();
    }
}
