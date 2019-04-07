using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class Wasteland : FieldSpell
    {
        public Wasteland(YugiohGame game) : base(game)
        {
            Name = "Wasteland";
            SetCodes.Add("SBLS-EN036");
            CardCode = 23424603;
            Description = "All Dinosaur, Zombie, and Rock monsters on the field gain 200 ATK/DEF.";
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
        public override void WhenRemoved() => throw new NotImplementedException();
    }
}
