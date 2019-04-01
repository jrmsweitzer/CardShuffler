using CardShuffler.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace CardShuffler.Models.Yugioh.YugiohCards
{
    public class SwordofDragonsSoul : EquipSpell
    {
        public SwordofDragonsSoul(YugiohGame game) : base(game)
        {
            Name = "Sword of Dragon's Soul";
            SetCodes.Add("SBLS-EN015");
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
