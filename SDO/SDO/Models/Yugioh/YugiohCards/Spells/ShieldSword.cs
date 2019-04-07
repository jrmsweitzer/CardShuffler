﻿using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class ShieldSword : NormalSpell
    {
        public ShieldSword(YugiohGame game) : base(game)
        {
            Name = "Shield & Sword";
            SetCodes.Add("SBLS-EN014");
            CardCode = 52097679;
            Description = "Switch the original ATK and DEF of all face-up monsters currently on the field, until the end of this turn.";
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
