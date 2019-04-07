using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class BurstStreamofDestruction : NormalSpell
    {
        public BurstStreamofDestruction(YugiohGame game) : base(game)
        {
            Name = "Burst Stream of Destruction";
            SetCodes.Add("SS02-ENA13");
            CardCode = 17655904;
            Description = "If you control \"Blue - Eyes White Dragon\": Destroy all monsters your opponent controls. \"Blue - Eyes White Dragon\" you control cannot attack the turn you activate this card.";
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
