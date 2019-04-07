using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class Twister : QuickplaySpell
    {
        public Twister(YugiohGame game) : base(game)
        {
            Name = "Twister";
            SetCodes.Add("SBLS-EN042");
            CardCode = 45939741;
            Description = "Pay 500 LP, then target 1 face-up Spell/Trap on the field; destroy that target.";
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
