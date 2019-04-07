using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class StrayLambs : NormalSpell
    {
        public StrayLambs(YugiohGame game) : base(game)
        {
            Name = "Stray Lambs";
            SetCodes.Add("SS02-ENB12");
            CardCode = 60764581;
            Description = "Special Summon 2 \"Lamb Tokens\" (Beast/EARTH/Level 1/ATK 0/DEF 0) in Defense Position. You cannot Summon other monsters the turn you activate this card (but you can Set).";
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
