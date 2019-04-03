using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class HalfShut : QuickplaySpell
    {
        public HalfShut(YugiohGame game) : base(game)
        {
            Name = "Half Shut";
            SetCodes.Add("SBLS-EN043");
            CardCode = 73048641;
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
