using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class TributeDoll : NormalSpell
    {
        public TributeDoll(YugiohGame game) : base(game)
        {
            Name = "Tribute Doll";
            SetCodes.Add("SS01-ENA13");
            CardCode = 02903036;
            Description = "Tribute 1 monster; Special Summon 1 Level 7 monster from your hand that can be Normal Summoned or Normal Set. It cannot attack this turn.";
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
