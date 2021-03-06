﻿using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class Twister : QuickplaySpell
    {
        public Twister(YugiohGame game) : base(game)
        {
            Name = "Twister";
            SetCodes.Add("SBLS-EN042");
            CardCode = 45939741;
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
