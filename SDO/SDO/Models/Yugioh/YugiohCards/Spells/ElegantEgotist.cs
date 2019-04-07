﻿using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ElegantEgotist : NormalSpell
    {
        public ElegantEgotist(YugiohGame game) : base(game)
        {
            Name = "Elegant Egotist";
            SetCodes.Add("SS02-ENC10");
            CardCode = 90219263;
            Description = "If \"Harpie Lady\" is on the field: Special Summon 1 \"Harpie Lady\" or \"Harpie Lady Sisters\" from your hand or Deck.";
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
