using SDO.Models.Yugioh.YugiohCardTypes;
using System;
using System.Collections.Generic;

namespace SDO.Models.Yugioh.YugiohCards
{
    public class DarkMagicAttack : NormalSpell
    {
        public DarkMagicAttack(YugiohGame game) : base(game)
        {
            Name = "Dark Magic Attack";
            SetCodes.Add("SS01-ENA11");
            CardCode = 02314238;
            Description = "If you control \"Dark Magician\": Destroy all Spells and Traps your opponent controls.";
        }

        public override bool Activate(params object[] targets) => throw new NotImplementedException();
        public override bool CanActivate() => throw new NotImplementedException();
        public override List<Card> GetLegalTargets() => throw new NotImplementedException();
        public override bool NeedsTarget() => throw new NotImplementedException();
        public override bool Resolve(params object[] targets) => throw new NotImplementedException();
    }
}
