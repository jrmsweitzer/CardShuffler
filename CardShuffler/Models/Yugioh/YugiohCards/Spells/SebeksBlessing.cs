using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class SebeksBlessing : QuickplaySpell
    {
        public SebeksBlessing(YugiohGame game) : base(game)
        {
            Name = "Sebek's Blessing";
            SetCodes.Add("SS01-ENB14");
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
