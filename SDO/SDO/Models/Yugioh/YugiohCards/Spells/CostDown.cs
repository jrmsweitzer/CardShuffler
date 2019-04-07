using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class CostDown : NormalSpell
    {
        public CostDown(YugiohGame game) : base(game)
        {
            Name = "Cost Down";
            SetCodes.Add("SS02-ENA12");
            CardCode = 23265313;
            Description = "Discard 1 card; for the rest of this turn, reduce the Levels of all monsters in your hand by 2 (even after they are Summoned).";
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
