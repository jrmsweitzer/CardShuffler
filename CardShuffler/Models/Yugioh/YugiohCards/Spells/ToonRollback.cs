﻿using System.Collections.Generic;
using CardShuffler.Models.Yugioh.YugiohCardTypes;

namespace CardShuffler.Models.Yugioh.YugiohCards.Spells
{
    public class ToonRollback : NormalSpell
    {
        public ToonRollback(YugiohGame game) : base(game)
        {
            Name = "Toon Rollback";
        }

        public override bool Activate(params object[] targets) => throw new System.NotImplementedException();
        public override bool CanActivate() => throw new System.NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new System.NotImplementedException();
        public override bool NeedsTarget() => throw new System.NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new System.NotImplementedException();
    }
}
