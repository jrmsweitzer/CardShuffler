using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class HiddenTemplesofNecrovalley : ContinuousSpell
    {
        public HiddenTemplesofNecrovalley(YugiohGame game) : base(game)
        {
            Name = "Hidden Temples of Necrovalley";
            SetCodes.Add("SS01-ENB13");
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
