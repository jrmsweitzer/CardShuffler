﻿using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class SagesStone : NormalSpell
    {
        public SagesStone(YugiohGame game) : base(game)
        {
            Name = "Sage's Stone";
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
