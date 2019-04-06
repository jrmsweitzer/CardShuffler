using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class Mimicat : NormalSpell
    {
        public Mimicat(YugiohGame game) : base(game)
        {
            Name = "Mimicat";
            SetCodes.Add("SS01-ENV03");
            CardCode = 88032456;
            Description = "If you control \"Toon World\" and a Toon monster: Target 1 card in your opponent's GY; if it is a monster, Special Summon it to your side of the field, or if it is a Spell/Trap Card, Set it to your side of the field. You can only activate 1 \"Mimicat\" per turn.";
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
