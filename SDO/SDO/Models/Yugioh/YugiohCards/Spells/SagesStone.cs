using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class SagesStone : NormalSpell
    {
        public SagesStone(YugiohGame game) : base(game)
        {
            Name = "Sage's Stone";
            SetCodes.Add("SS01-ENA10");
            CardCode = 13604200;
            Description = "If you control a face-up \"Dark Magician Girl\": Special Summon 1 \"Dark Magician\" from your hand or Deck.";
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
