using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class BlockAttack : NormalSpell
    {
        public BlockAttack(YugiohGame game) : base(game)
        {
            Name = "Block Attack";
            SetCodes.Add("SBLS-EN038");
            CardCode = 25880422;
            Description = "Target 1 face-up Attack Position monster your opponent controls; change that target to face-up Defense Position.";
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
